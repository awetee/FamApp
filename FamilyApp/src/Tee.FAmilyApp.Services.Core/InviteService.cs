using System.Collections.Generic;
using System.Linq;
using Tee.FamilyApp.Common.Core;
using Tee.FamilyApp.Common.Core.Entities;
using Tee.FamilyApp.Common.Core.Enums;
using Tee.FamilyApp.DAL.Core.Repository;

namespace Tee.FamilyApp.Services.Core
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

            SendInviteEmail(invite);

            return result;
        }

        private void SendInviteEmail(Invite invite)
        {
            this._emailService.SendEmailAsync(invite.EmailAddress, "Roots Invite", $"You've been invited to roots by: {invite.BranchId}");
        }
    }
}