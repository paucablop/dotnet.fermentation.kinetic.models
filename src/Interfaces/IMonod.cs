using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface ISimpleMonod
    {
        float MaxGrowthRate { get; init; }
        float AffinityConstant { get; init; }
    }
    
    [PublicAPI]
    public interface IMonodInhibition : ISimpleMonod
    {
        float InhibitionConstant { get; init; }
    }
}