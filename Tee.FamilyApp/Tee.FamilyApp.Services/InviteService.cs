using System.Collections.Generic;
using System.Linq;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> InviteRepository;

        public InviteService() : this(new Repository<Invite>(new RootContext()))
        {
        }

        public InviteService(IRepository<Invite> inviteRepository)
        {
            this.InviteRepository = inviteRepository;
        }

        public IBranchService BranchService { get; private set; }

        public IEnumerable<Invite> GetPendingReceivedInvitesByBranch(int branchId)
        {
            return this.InviteRepository.GetAll().Where(i => i.BranchId == branchId);
        }

        public IEnumerable<Invite> GetPendingInvitesForUser(string userName)
        {
            var user = this.BranchService.GetBranchByUserName(userName);

            return this.InviteRepository.GetAll().Where(i => i.BranchId == user.Id && i.Status == InviteStatus.Sent);
        }

        public OperationResult SendInvitation(Invite invite, string userName)
        {
            var result = new OperationResult();

            if (invite == null)
            {
                result.Succeded = false;
                result.Messages.Add("Invite is null");

                return result;
            }

            this.InviteRepository.Add(invite);

            return result;
        }
    }
}