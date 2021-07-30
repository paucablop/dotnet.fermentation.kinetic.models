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
            var rate = Inhibition.LinearInhibition(productConcentration, inhibitionConstant);

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
            var rate = Inhibition.ExponentialInhibition(productConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.6065306597126334, 1e-8);
        }
        
        [Fact]
        public void TestInverseInhibition()
        {
            // Arrange
            var inhibitorConcentration = 0.5;
            var inhibitionConstant = 1.0;

            // Act
            var rate = Inhibition.InverseInhibition(inhibitorConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.6666666666666666, 1e-8);
        }

        [Fact]
        public void TestSuddenInhibition()
        {
            // Arrange
            var productConcentration = 0.5;
            var inhibitionConstant = 1.0;
            var exponentialConstant = 1.0;

            // Act
            var rate = Inhibition.SuddenInhibition(productConcentration, inhibitionConstant, exponentialConstant);

            // Assert
            rate.Should().BeApproximately(0.5, 1e-8);
        }
    }
}