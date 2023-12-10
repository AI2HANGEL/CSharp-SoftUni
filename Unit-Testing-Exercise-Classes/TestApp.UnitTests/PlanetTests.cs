using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double calculatedGravity = earth.CalculateGravity(mass);

        // Assert
        Assert.AreEqual(expectedGravity, calculatedGravity);
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet mars = new Planet("Mars", 6779, 227900000, 2);

        // Act
        string planetInfo = mars.GetPlanetInfo();

        // Assert
        string expectedInfo =
            "Planet: Mars" + Environment.NewLine +
            "Diameter: 6779 km" + Environment.NewLine +
            "Distance from the Sun: 227900000 km" + Environment.NewLine +
            "Number of Moons: 2";

        Assert.That(planetInfo, Is.EqualTo(expectedInfo));
    }
}
