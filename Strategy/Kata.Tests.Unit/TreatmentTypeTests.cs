using Kata.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Kata.Tests.Unit
{
    [TestClass]
    public class TreatmentTypeTests
    {
        [TestMethod]
        public void Constructors_Public_ShouldBeNone()
        {
            var treatmentTypeConstructorCount = typeof(TreatmentType).GetConstructors()
             .Where(constructorInfo => constructorInfo.IsPublic).Count();

            Assert.AreEqual(0, treatmentTypeConstructorCount);
        }

        [TestMethod]
        public void CreationMethod_SurgeryTreatmentEnumInput_ReturnsInstanceOfSurgery()
        {
            var surgeryTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Surgery);
            Assert.IsInstanceOfType(surgeryTreatment, typeof(Surgery));
            Assert.IsInstanceOfType(surgeryTreatment, typeof(TreatmentType));
        }

        [TestMethod]
        public void CreationMethod_DietaryTreatmentEnumInput_ReturnsInstanceOfDietary()
        {
            var dietaryTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Dietary);
            Assert.IsInstanceOfType(dietaryTreatment, typeof(Dietary));
            Assert.IsInstanceOfType(dietaryTreatment, typeof(TreatmentType));
        }

        [TestMethod]
        public void CreationMethod_HydrationTreatmentEnumInput_ReturnsInstanceOfHydration()
        {
            var hydrationTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Hydration);
            Assert.IsInstanceOfType(hydrationTreatment, typeof(Hydration));
            Assert.IsInstanceOfType(hydrationTreatment, typeof(TreatmentType));
        }

        [TestMethod]
        public void CreationMethod_PrescriptionTreatmentEnumInput_ReturnsInstanceOfPrescription()
        {
            var prescriptionTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Prescription);
            Assert.IsInstanceOfType(prescriptionTreatment, typeof(Prescription));
            Assert.IsInstanceOfType(prescriptionTreatment, typeof(TreatmentType));
        }

        [TestMethod]
        public void CreationMethod_ReferralTreatmentEnumInput_ReturnsInstanceOfReferral()
        {
            var referalTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Referral);
            Assert.IsInstanceOfType(referalTreatment, typeof(Referral));
            Assert.IsInstanceOfType(referalTreatment, typeof(TreatmentType));
        }

        [TestMethod]
        public void CourseOfActionProperty_SurgeryTreamentEnumInput_ReturnsSurgeryCourseOfAction()
        {
            var surgeryTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Surgery);
            Assert.AreEqual("Do something.", surgeryTreatment.CourseOfAction);
            
        }

        [TestMethod]
        public void CourseOfActionProperty_DietaryTreamentEnumInput_ReturnsDietaryCourseOfAction()
        {
            var dietaryTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Dietary);
            Assert.AreEqual("Give dietary advice.", dietaryTreatment.CourseOfAction);
           
        }

        [TestMethod]
        public void CourseOfActionProperty_HydrationTreamentEnumInput_ReturnsHydrationCourseOfAction()
        {
            var hydrationTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Hydration);
            Assert.AreEqual("Hydrate the pet.", hydrationTreatment.CourseOfAction);
        }

        [TestMethod]
        public void CourseOfActionProperty_PrescriptionTreamentEnumInput_ReturnsPrescriptionCourseOfAction()
        {
            var prescriptionTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Prescription);
            Assert.AreEqual("Do prescription.", prescriptionTreatment.CourseOfAction);
        }

        [TestMethod]
        public void CourseOfActionProperty_ReferalTreamentEnumInput_ReturnsPrescriptionCourseOfAction()
        {
            var referalTreatment = TreatmentType.CreateTreatment(Treatment.TreatmentEnum.Referral);
            Assert.AreEqual("Do referral.", referalTreatment.CourseOfAction);
        }

        [TestMethod]
        public void Constructor_TreatmentEnumParam_ReturnsCorrectCourseOfActionProperty()
        {
            var dietaryTreatment = new Treatment(Treatment.TreatmentEnum.Dietary);
            Assert.AreEqual("Give dietary advice.", dietaryTreatment.TreatmentType.CourseOfAction);
        }
    }
}
