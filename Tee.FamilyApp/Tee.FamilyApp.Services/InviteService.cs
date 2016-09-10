using System.Collections.Generic;
using System.Linq;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.Common.Entities;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> _inviteRepository;
        private readonly IEmailService _emailService;
        private readonly IBranchService _branchService;

        public InviteService(IRepository<Invite> inviteRepository, IEmailService emailService, IBranchService branchService)
        {
            this._inviteRepository = inviteRepository;
            this._emailService = emailService;
            _branchService = branchService;
        }

        public IEnumerable<Invite> GetPendingReceivedInvitesByBranch(int branchId)
        {
            return this._inviteRepository.GetAll().Where(i => i.BranchId == branchId);
        }

        public IEnumerable<Invite> GetPendingInvitesForUser(string userName)
        {
            var user = this._branchService.GetBranchByUserName(userName);

            return this._inviteRepository.GetAll().Where(i => i.BranchId == user.Id && i.Status == InviteStatus.Sent);
        }

        public OperationResult SendInvitation(Invite invite)
        {
            var result = new OperationResult();

            if (invite == null)
            {
                result.Succeded = false;
                result.Messages.Add("Invite is null");

                return result;
            }

            this._inviteRepository.Add(invite);

            if (invite.Type != InviteType.Email) return result;

            var email = new Email
            {
                EmailAddress = "adebiyi.tee@gmail.com",
                Subject = "Roots Invite",
                Body = $"You've been invited to roots by: {invite.BranchId}"
            };

            this._emailService.SendEmail(email);

            return result;
        }
    }
}