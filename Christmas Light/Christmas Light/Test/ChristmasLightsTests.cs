using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Christmas_Light.Tests
{
    [TestClass()]
    public class ChristmasLightsTests
    {
        ChristmasLights _Manager = new ChristmasLights();

        [TestInitialize]
        public void Init()
        {

        }

        [DataTestMethod]
        [DataRow(1, new Point(2, 2), new List<bool> { true, true, true, true })]
        public void When_All_Lights_Off_ToggleLightsInArea_Should_All_Lights_In_Area_Turns_On(
            Point upperLeftCorner,
            Point downRightCorner,
            List<bool> expectedListResult)
        {
            Point leftUpperCorner = new Point(0, 0);
            Point donwRightCorner = new Point(2, 2);
            List<bool> expectedResult = new List<bool> { true, true, true, true };
            var result = _Manager.ToggleLightsInArea(leftUpperCorner, donwRightCorner);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}