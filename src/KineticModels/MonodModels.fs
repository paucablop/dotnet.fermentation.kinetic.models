namespace Fermentation.Kinetic.Models

open Fermentation.Kinetic.Interfaces

type MonodModels() =
    static member SimpleMonod (substrateConcentration: float, maxGrowthRate: float, affinityConstant: float) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant + substrateConcentration)

    static member SimpleMonod (substrateConcentration: float, simpleMonodConstants: ISimpleMonod) =
        MonodModels.SimpleMonod(
            substrateConcentration,
            float (simpleMonodConstants.MaxGrowthRate),
            float (simpleMonodConstants.AffinityConstant)
        )

    static member MonodSubstrateInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant
           + substrateConcentration
           + substrateConcentration ** 2.0 / inhibitionConstant)

    static member MonodSubstrateInhibition (substrateConcentration: float, substrateInhibitionMonodConstants: IMonodInhibition) =
        MonodModels.MonodSubstrateInhibition(
            substrateConcentration,
            float (substrateInhibitionMonodConstants.MaxGrowthRate),
            float (substrateInhibitionMonodConstants.AffinityConstant),
            float (substrateInhibitionMonodConstants.InhibitionConstant)
        )

    static member MonodSubstrateCompetitiveInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate
        / ((1.0 + affinityConstant / substrateConcentration)
           * (1.0 + substrateConcentration / inhibitionConstant))

    static member MonodSubstrateCompetitiveInhibition
        (
            substrateConcentration: float,
            substrateInhibitionMonodConstants: IMonodInhibition
        ) =
        MonodModels.MonodSubstrateCompetitiveInhibition(
            substrateConcentration,
            float (substrateInhibitionMonodConstants.MaxGrowthRate),
            float (substrateInhibitionMonodConstants.AffinityConstant),
            float (substrateInhibitionMonodConstants.InhibitionConstant)
        )

    static member MonodSubstrateNonCompetitiveInhibition
        (
            substrateConcentration: float,
            maxGrowthRate: float,
            affinityConstant: float,
            inhibitionConstant: float
        ) =
        maxGrowthRate * substrateConcentration
        / (affinityConstant
           * (1.0 + substrateConcentration / inhibitionConstant)
           + substrateConcentration)

    static member MonodSubstrateNonCompetitiveInhibition
        (
            substrateConcentration: float,
            substrateInhibitionMonodConstants: IMonodInhibition
        ) =
        MonodModels.MonodSubstrateNonCompetitiveInhibition(
            substrateConcentration,
            float(substrateInhibitionMonodConstants.MaxGrowthRate),
            float(substrateInhibitionMonodConstants.AffinityConstant),
            float(substrateInhibitionMonodConstants.InhibitionConstant)
        )
