using Fermentation.Kinetic.Models;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class ProductInhibitionUnitTests
    {
        [Fact]
        public void TestLinearInhibition()
        {
            // Arrange
            var productConcentration = 0.5;
            var inhibitionConstant = 1.0;

            // Act
            var rate = ProductInhibition.LinearInhibition(productConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.5, 1e-8);
        }

        [Fact]
        public void TestExponentialInhibition()
        {
            // Arrange
            var productConcentration = 0.5;
            var inhibitionConstant = 1.0;

            // Act
            var rate = ProductInhibition.ExponentialInhibition(productConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.6065306597126334, 1e-8);
        }

        [Fact]
        public void TestSuddenInhibition()
        {
            // Arrange
            var productConcentration = 0.5;
            var inhibitionConstant = 1.0;

            // Act
            var rate = ProductInhibition.SuddenInhibition(productConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.5, 1e-8);
        }

        [Fact]
        public void TestSuddenInhibitionWithNonDefaultInhibitionExponent()
        {
            // Arrange
            var productConcentration = 0.5;
            var inhibitionConstant = 1.0;
            var inhibitionExponent = 2.0;

            // Act
            var rate = ProductInhibition.SuddenInhibition(productConcentration, inhibitionConstant, inhibitionExponent);

            // Assert
            rate.Should().BeApproximately(0.75, 1e-8);
        }
    }
}