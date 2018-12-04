using Kata.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests.Unit
{
    [TestClass]
    public class TreatmentTests
    {
        [TestMethod]
        public void Constructor_NoInputParams_IsInstanceOfDomainEntity()
        {
            var sut = new Treatment();
            Assert.IsInstanceOfType(sut, typeof(DomainEntity));
        }
    }
}
