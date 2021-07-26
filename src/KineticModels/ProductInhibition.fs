namespace Fermentation.Kinetic.Models

open System
open System.Runtime.InteropServices

module ProductInhibition =
    (*
    source : Dynamics of inhibition patterns during fermentation processes-Zea Mays and Sorghum Bicolor case study
    *)
    let LinearInhibition (productConcentration: float, inhibitionConstant: float) =
        1.0 - productConcentration * inhibitionConstant

    let ExponentialInhibition (productConcentration: float, inhibitionConstant: float) =
        Math.Exp(-productConcentration * inhibitionConstant)

    let SuddenInhibition
        (
            productConcentration: float,
            inhibitionConstant: float,
            [<Optional; DefaultParameterValue(1)>] inhibitionExponent: float
        ) =
        1.0
        - (productConcentration / inhibitionConstant)
          ** inhibitionExponent
