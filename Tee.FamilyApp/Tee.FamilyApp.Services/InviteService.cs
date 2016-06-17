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

        public OperationResult SendInvitation(Invite invite)
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