using Fermentation.Kinetic.Models;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class CompetitiveInhibitionUnitTests
    {
        [Fact]
        public void TestInhibitionFactor()
        {
            // Arrange
            var inhibitorConcentration = 0.5;
            var inhibitionConstant = 1.0;

            // Act
            var rate = CompetitiveInhibition.InhibitionFator(inhibitorConcentration, inhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.6666666666666666, 1e-8);
        }
        
    }
}