using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IInhibitorInhibition
    {
        float InhibitionConstant { get; init; }
    }
}
