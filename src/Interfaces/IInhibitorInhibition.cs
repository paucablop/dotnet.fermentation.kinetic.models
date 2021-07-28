using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IInhibitorInhibition
    {
        double InhibitionConstant { get; init; }
    }
}
