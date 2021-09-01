namespace Fermentation.Kinetic.Models

open Fermentation.Kinetic.Interfaces

type UptakeModels() =
    static member Monod(substrateConcentration: float, maxUptakeRate: float, affinityConstant: float) =
        maxUptakeRate * substrateConcentration
        / (affinityConstant + substrateConcentration)

    static member Monod(substrateConcentration: float, monodConstants: IMonod) =
        UptakeModels.Monod(
            substrateConcentration,
            float (monodConstants.MaxUptakeRate),
            float (monodConstants.AffinityConstant)
        )

    static member MonodSubstrateInhibition
        (
            substrateConcentration: float,
            maxUptakeRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxUptakeRate * substrateConcentration
        / (affinityConstant
           + substrateConcentration
           + (substrateConcentration * substrateConcentration) / inhibitionConstant)

    static member MonodSubstrateInhibition
        (
            substrateConcentration: float,
            monodSubstrateInhibitionConstants: IMonodInhibition
        ) =
        UptakeModels.MonodSubstrateInhibition(
            substrateConcentration,
            float (monodSubstrateInhibitionConstants.MaxUptakeRate),
            float (monodSubstrateInhibitionConstants.AffinityConstant),
            float (monodSubstrateInhibitionConstants.InhibitionConstant)
        )

    static member MonodSubstrateCompetitiveInhibition
        (
            substrateConcentration: float,
            maxUptakeRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxUptakeRate
        / ((1.0 + affinityConstant / substrateConcentration)
           * (1.0 + substrateConcentration / inhibitionConstant))

    static member MonodSubstrateCompetitiveInhibition
        (
            substrateConcentration: float,
            monodSubstrateInhibitionConstants: IMonodInhibition
        ) =
        UptakeModels.MonodSubstrateCompetitiveInhibition(
            substrateConcentration,
            float (monodSubstrateInhibitionConstants.MaxUptakeRate),
            float (monodSubstrateInhibitionConstants.AffinityConstant),
            float (monodSubstrateInhibitionConstants.InhibitionConstant)
        )

    static member MonodSubstrateNonCompetitiveInhibition
        (
            substrateConcentration: float,
            maxUptakeRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxUptakeRate * substrateConcentration
        / (affinityConstant
           * (1.0 + substrateConcentration / inhibitionConstant)
           + substrateConcentration)

    static member MonodSubstrateNonCompetitiveInhibition
        (
            substrateConcentration: float,
            substrateInhibitionMonodConstants: IMonodInhibition
        ) =
        UptakeModels.MonodSubstrateNonCompetitiveInhibition(
            substrateConcentration,
            float (substrateInhibitionMonodConstants.MaxUptakeRate),
            float (substrateInhibitionMonodConstants.AffinityConstant),
            float (substrateInhibitionMonodConstants.InhibitionConstant)
        )
