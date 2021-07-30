using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IInhibition
    {
        double InhibitionConstant { get; init; }
    }
    
    [PublicAPI]
    public interface ILinearInhibition : IInhibition
    {
    }

    [PublicAPI]
    public interface IExponentialInhibition : IInhibition
    {
    }
    
    [PublicAPI]
    public interface IInverseInhibition : IInhibition
    {
    }
    
    [PublicAPI]
    public interface ISuddenInhibition : IInhibition
    {
        double ExponentialConstant { get; init; }
    }
}