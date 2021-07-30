using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IMonod
    {
        double MaxUptakeRate { get; init; }
        double AffinityConstant { get; init; }
    }
    
    [PublicAPI]
    public interface IMonodInhibition : IMonod
    {
        double InhibitionConstant { get; init; }
    }
}