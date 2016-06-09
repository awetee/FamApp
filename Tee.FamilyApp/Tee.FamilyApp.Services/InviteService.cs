using System;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;
using Tee.FamilyApp.Web.Controllers;

namespace Tee.FamilyApp.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> InviteRepository;

        public InviteService() : this(new Repository<Invite>())
        {
        }

        public InviteService(IRepository<Invite> inviteRepository)
        {
            this.InviteRepository = inviteRepository;
        }

        public bool SendInvitation(Invite invite)
        {
            bool result = false;

            try
            {
                this.InviteRepository.Add(invite);
                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}