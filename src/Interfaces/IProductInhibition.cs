using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IInhibition
    {
        double InhibitionConstant { get; set; }
        public double Calculate();

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
        double ExponentialConstant { get; set; }
    }
}
