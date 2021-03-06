using Fermentation.Kinetic.Models;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class KineticModelsUnitTests
    {
        [Fact]
        public void TestMonod()
        {
            // Arrange
            var substrateConcentration = 0.5;
            var maxGrowthRate = 1;
            var affinityConstant = 0.5;

            // Act
            var rate = UptakeModels.Monod(substrateConcentration, maxGrowthRate, affinityConstant);

            // Assert
            rate.Should().Be(0.5);
        }

        [Fact]
        public void TestMonodSubstrateInhibition()
        {
            // Arrange
            var substrateConcentration = 1.0;
            var maxGrowthRate = 0.5;
            var affinityConstant = 0.5;
            var substrateInhibitionConstant = 1.0;

            // Act
            var rate = UptakeModels.MonodSubstrateInhibition(substrateConcentration, maxGrowthRate, affinityConstant,
                substrateInhibitionConstant);

            // Assert
            rate.Should().Be(0.2);
        }
        
        [Fact]
        public void TestMonodSubstrateCompetitiveInhibition()
        {
            // Arrange
            var substrateConcentration = 0.5;
            var maxGrowthRate = 1;
            var affinityConstant = 0.5;
            var substrateInhibitionConstant = 1;

            // Act
            var rate = UptakeModels.MonodSubstrateCompetitiveInhibition(substrateConcentration, maxGrowthRate, affinityConstant,
                substrateInhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.3333333333333333, 1e-8);
        }
        [Fact]
        public void TestMonodSubstrateNonompetitiveInhibition()
        {
            // Arrange
            var substrateConcentration = 0.5;
            var maxGrowthRate = 1;
            var affinityConstant = 0.5;
            var substrateInhibitionConstant = 1;

            // Act
            var rate = UptakeModels.MonodSubstrateCompetitiveInhibition(substrateConcentration, maxGrowthRate, affinityConstant,
                substrateInhibitionConstant);

            // Assert
            rate.Should().BeApproximately(0.3333333333333333, 1e-8);
        }
        
    }
}