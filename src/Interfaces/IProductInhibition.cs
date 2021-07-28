using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface ILinearProductInhibition
    {
        double InhibitionConstant { get; init; }
    }

    [PublicAPI]
    public interface IExponentialProductInhibition : ILinearProductInhibition
    {
    }

    [PublicAPI]
    public interface ISuddenProductInhibition : ILinearProductInhibition
    {
        double InhibitionExponent { get; init; }
    }
}