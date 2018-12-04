using Kata.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests.Unit
{
    [TestClass]
    public class DomainEntityTests
    {
        [TestMethod]
        public void TwoInstances_SameIdPropertySet_AreEqual()
        {
            const int commonId = 32753;
            var sut1 = new DomainEntity { Id = commonId };
            var sut2 = new DomainEntity { Id = commonId };
            Assert.AreEqual(sut1, sut2);

        }

        [TestMethod]
        public void TwoInstances_DifferentIdPropertySet_AreNotEqual()
        {
            var sut1 = new DomainEntity { Id = 4275 };
            var sut2 = new DomainEntity { Id = 3214 };
            Assert.AreNotEqual(sut1, sut2);
            
        }
    }
}
