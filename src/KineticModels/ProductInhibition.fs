namespace Fermentation.Kinetic.Models

open System
open System.Runtime.InteropServices
open Fermentation.Kinetic.Interfaces

type ProductInhibition =
    (*
    source : Dynamics of inhibition patterns during fermentation processes-Zea Mays and Sorghum Bicolor case study
    *)
    static member LinearInhibition(productConcentration: float, inhibitionConstant: float) =
        1.0 - productConcentration * inhibitionConstant

    static member LinearInhibition(productConcentration: float, productInhibitionConstants: ILinearProductInhibition) =
        ProductInhibition.LinearInhibition(productConcentration, productInhibitionConstants.InhibitionConstant)

    static member ExponentialInhibition(productConcentration: float, inhibitionConstant: float) =
        Math.Exp(-productConcentration * inhibitionConstant)

    static member ExponentialInhibition
        (
            productConcentration: float,
            productInhibitionConstants: IExponentialProductInhibition
        ) =
        ProductInhibition.ExponentialInhibition(productConcentration, productInhibitionConstants.InhibitionConstant)

    static member SuddenInhibition
        (
            productConcentration: float,
            inhibitionConstant: float,
            [<Optional; DefaultParameterValue(1)>] inhibitionExponent: float
        ) =
        1.0
        - (productConcentration / inhibitionConstant)
          ** inhibitionExponent

    static member SuddenInhibition(productConcentration: float, productInhibitionConstants: ISuddenProductInhibition) =
        ProductInhibition.SuddenInhibition(
            productConcentration,
            productInhibitionConstants.InhibitionConstant,
            productInhibitionConstants.InhibitionExponent
        )
