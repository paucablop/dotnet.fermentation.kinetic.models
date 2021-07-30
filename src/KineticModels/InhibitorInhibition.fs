namespace Fermentation.Kinetic.Models

open Fermentation.Kinetic.Interfaces

type InhibitorInhibition =
    static member InhibitionFator (inhibitorConcentration: float, inhibitionConstant: float) =
        1.0
        / (1.0 + inhibitorConcentration / inhibitionConstant)

    static member InhibitionFator (inhibitorConcentration: float, inhibitionConstant: IInhibitorInhibition) =
        InhibitorInhibition.InhibitionFator(inhibitorConcentration, inhibitionConstant.InhibitionConstant)
