using System.Collections.Generic;
using System.Linq;
using Tee.FamilyApp.Common;
using Tee.FamilyApp.Common.Models;
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

        public IEnumerable<InviteViewModel> GetPendingInvitesForUser(string userName)
        {
            var user = this.BranchService.GetBranchByUserName(userName);
            var result = new List<InviteViewModel>();
            var pendingInvites = this.InviteRepository.GetAll().Where(i => i.BranchId == user.Id && i.Status == InviteStatus.Sent);
            foreach (var invite in pendingInvites)
            {
                result.Add(this.MapToInviteViewModel(invite));
            }

            return result;
        }

        public OperationResult SendInvitation(InviteViewModel invite, string userName)
        {
            var result = new OperationResult();

            if (invite == null)
            {
                result.Succeded = false;
                result.Messages.Add("Invite is null");

                return result;
            }

            this.InviteRepository.Add(MapToInvite(invite, userName));

            return result;
        }

        private Invite MapToInvite(InviteViewModel model, string userName)
        {
            var branch = this.BranchService.GetBranchByUserName(userName);

            //TODO: we probably need an auto mapper here
            var invite = new Invite
            {
                BranchId = branch.Id,
                EmailAddress = model.Email,
                LinkType = model.LinkType,
                Status = InviteStatus.Sent
            };

            return invite;
        }

        private InviteViewModel MapToInviteViewModel(Invite model)
        {
            var invite = new InviteViewModel
            {
                Email = model.EmailAddress,
                LinkType = model.LinkType
            };

            return invite;
        }
    }
}