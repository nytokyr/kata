using Kata.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests.Unit
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void Constructor_NoInputParams_IsInstanceOfDomainEntity()
        {
            var sut = new Pet();
            Assert.IsInstanceOfType(sut, typeof(DomainEntity));
        }

        [TestMethod]
        public void TreatmentsProperty_Get_HasCountOf_0_Initially()
        {
            var sut = new Pet();
            Assert.AreEqual(0, sut.Treatments.Count);
        }

        [TestMethod]
        public void AddTreatmentMethod_PetInputParam_IncrementsTreatmentsCount()
        {
            var sut = new Pet();
            Assert.AreEqual(0, sut.Treatments.Count);
            sut.AddTreatment(new Treatment());
            Assert.AreEqual(1, sut.Treatments.Count);
        }
    }
}
