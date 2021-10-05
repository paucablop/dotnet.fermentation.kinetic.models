using JetBrains.Annotations;

namespace Fermentation.Kinetic.Interfaces
{
    [PublicAPI]
    public interface IMonod
    {
        double MaxUptakeRate { get; set; }
        double AffinityConstant { get; set; }
        public double Calculate(double compoundConcentration);
    }
    
    [PublicAPI]
    public interface IMonodInhibition : IMonod
    {
        double InhibitionConstant { get; set; }
    }
}
