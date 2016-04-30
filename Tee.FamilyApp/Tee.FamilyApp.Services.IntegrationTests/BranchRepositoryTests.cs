using NUnit.Framework;
using Tee.FamilyApp.DAL.Entities;
using Tee.FamilyApp.DAL.Repository;

namespace Tee.FamilyApp.Services.UnitTests
{
    [TestFixture]
    public class BranchRepositoryTests
    {
        private IRepository<Branch> repository;

        public BranchRepositoryTests()
        {
            this.repository = new Repository<Branch>();
        }

        [Test]
        public void GetShouldReturnValidResult()
        {
            var result = this.repository.GetAll();
            Assert.IsNotEmpty(result);
        }
    }
}