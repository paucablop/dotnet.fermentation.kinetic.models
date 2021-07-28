using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface ILinearProductInhibition
    {
        float InhibitionConstant { get; init; }
    }

    [PublicAPI]
    public interface IExponentialProductInhibition : ILinearProductInhibition
    {
    }

    [PublicAPI]
    public interface ISuddenProductInhibition : ILinearProductInhibition
    {
        float InhibitionExponent { get; init; }
    }
}