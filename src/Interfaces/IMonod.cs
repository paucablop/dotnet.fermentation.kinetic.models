using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface ISimpleMonod
    {
        double MaxGrowthRate { get; init; }
        double AffinityConstant { get; init; }
    }
    
    [PublicAPI]
    public interface IMonodInhibition : ISimpleMonod
    {
        double InhibitionConstant { get; init; }
    }
}