namespace Fermentation.Kinetic.Models

open System
open Fermentation.Kinetic.Interfaces

type Inhibition =
    (*
    source : Dynamics of inhibition patterns during fermentation processes-Zea Mays and Sorghum Bicolor case study
    *)
    static member LinearInhibition(productConcentration: float, inhibitionConstant: float) =
        1.0 - productConcentration * inhibitionConstant

    static member LinearInhibition(productConcentration: float, linearInhibitionConstants: ILinearInhibition) =
        Inhibition.LinearInhibition(productConcentration, linearInhibitionConstants.InhibitionConstant)

    static member ExponentialInhibition(productConcentration: float, inhibitionConstant: float) =
        Math.Exp(-productConcentration * inhibitionConstant)

    static member ExponentialInhibition
        (
            productConcentration: float,
            exponentialInhibitionConstants: IExponentialInhibition
        ) =
        Inhibition.ExponentialInhibition(productConcentration, exponentialInhibitionConstants.InhibitionConstant)

    static member InverseInhibition (inhibitorConcentration: float, inhibitionConstant: float) =
        1.0
        / (1.0 + inhibitorConcentration / inhibitionConstant)

    static member InverseInhibition (inhibitorConcentration: float, inverseInhibitionConstant: IInverseInhibition) =
        Inhibition.InverseInhibition(inhibitorConcentration, inverseInhibitionConstant.InhibitionConstant)
    
    static member SuddenInhibition
        (
            productConcentration: float,
            inhibitionConstant: float,
            exponentialConstant: float
        ) =
        1.0
        - (productConcentration / inhibitionConstant)
          ** exponentialConstant

    static member SuddenInhibition(productConcentration: float, suddentInhibitionConstants: ISuddenInhibition) =
        Inhibition.SuddenInhibition(
            productConcentration,
            suddentInhibitionConstants.InhibitionConstant,
            suddentInhibitionConstants.ExponentialConstant
        )
        


