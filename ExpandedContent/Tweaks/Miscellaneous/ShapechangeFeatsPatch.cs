﻿using ExpandedContent.Extensions;
using ExpandedContent.Utilities;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System.Linq;
using Kingmaker.UnitLogic.Mechanics.Conditions;
using Kingmaker.Utility;
using Kingmaker.Designers.EventConditionActionSystem.Conditions;
using static UnityModManagerNet.UnityModManager;

namespace ExpandedContent.Tweaks.Miscellaneous {
    internal class ShapechangeFeatsPatch {


        protected static bool IsTabletopTweaksBaseEnabled() { return IsModEnabled("TabletopTweaks-Base"); }

        public static void AddShapechangeFeatsPatch() {




            //Shifters Rush Buff
            var WildShapeDragonShapeBiteAbility = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBiteAbility");
            var WildShapeDragonShapeGreen = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeGreen");
            var WildShapeDragonShapeSilver = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeSilver");
            var WildShapeDragonShapeBlack = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBlack");
            var WildShapeDragonShapeBlue = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBlue");
            var WildShapeDragonShapeBrass = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBrass");
            var WildShapeDragonShapeRed = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeRed");
            var WildShapeDragonShapeWhite = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeWhite");
            var WildShapeDragonShapeGreen2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeGreen2");
            var WildShapeDragonShapeSilver2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeSilver2");
            var WildShapeDragonShapeBlack2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBlack2");
            var WildShapeDragonShapeBlue2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBlue2");
            var WildShapeDragonShapeBrass2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeBrass2");
            var WildShapeDragonShapeRed2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeRed2");
            var WildShapeDragonShapeWhite2 = Resources.GetModBlueprint<BlueprintAbility>("WildShapeDragonShapeWhite2");
            var TreesingerWildShapeMandragoraAbility = Resources.GetModBlueprint<BlueprintAbility>("TreesingerWildShapeMandragoraAbility");
            var TreesingerWildShapeShamblingMoundAbility = Resources.GetModBlueprint<BlueprintAbility>("TreesingerWildShapeShamblingMoundAbility");
            var TreesingerWildShapeQuickwoodAbility = Resources.GetModBlueprint<BlueprintAbility>("TreesingerWildShapeQuickwoodAbility");
            var TreesingerWildShapeGiantFlytrapAbility = Resources.GetModBlueprint<BlueprintAbility>("TreesingerWildShapeGiantFlytrapAbility");
            var TreesingerWildShapeTreantAbility = Resources.GetModBlueprint<BlueprintAbility>("TreesingerWildShapeTreantAbility");
            var ShiftersRushBuff = Resources.GetBlueprint<BlueprintBuff>("c3365d5a75294b9b879c587668620bd4");
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBiteAbility.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeGreen.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeSilver.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBlack.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBlue.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBrass.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeRed.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeWhite.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeGreen2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeSilver2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBlack2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBlue2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeBrass2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeRed2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = WildShapeDragonShapeWhite2.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = TreesingerWildShapeMandragoraAbility.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = TreesingerWildShapeShamblingMoundAbility.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = TreesingerWildShapeQuickwoodAbility.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = TreesingerWildShapeGiantFlytrapAbility.ToReference<BlueprintAbilityReference>(); });
            ShiftersRushBuff.AddComponent<FreeActionSpell>(c => { c.m_Ability = TreesingerWildShapeTreantAbility.ToReference<BlueprintAbilityReference>(); });

            
            var WildShapeDragonShapeBiteFeature = Resources.GetModBlueprint<BlueprintFeature>("WildShapeDragonShapeBiteFeature");            
            var TreesingerWildShapeMandragoraFeature = Resources.GetModBlueprint<BlueprintFeature>("TreesingerWildShapeMandragoraFeature");            
            if (!IsTabletopTweaksBaseEnabled()) {  //TTT disabled
                var ShiftersRushFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("4ddc88f422a84f76a952e24bec7b53e1").GetComponent<PrerequisiteCondition>().Condition;
                var ShiftersRushFeatureConditionsChecker = ShiftersRushFeatureCondition as OrAndLogic;
                ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions = ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions = ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                var EnergizedWildShapeFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("92df031ed2cb4153950853d6a3b9813e").GetComponent<PrerequisiteCondition>().Condition;
                var EnergizedWildShapeFeatureConditionsChecker = EnergizedWildShapeFeatureCondition as OrAndLogic;
                EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions = EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions = EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                var RakingClawsFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("a1b262d2b1ef478994113fc941fa3a32").GetComponent<PrerequisiteCondition>().Condition;
                var RakingClawsFeatureConditionsChecker = RakingClawsFeatureCondition as OrAndLogic;
                RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions = RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions = RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                var FrightfulShapeFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("8e8a34c754d649aa9286fe8ee5cc3f10").GetComponent<PrerequisiteCondition>().Condition;
                var FrightfulShapeFeatureConditionsChecker = FrightfulShapeFeatureCondition as OrAndLogic;
                FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions = FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                    );
                FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions = FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                    new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                    );
            }
            if (IsTabletopTweaksBaseEnabled()) { //TTT enabled

                if (ModSupportUtilities.GetShiftersRushTTTBaseSetting()) { //TTT Option ON - Shifters Rush
                    var ShiftersRushFeaturePrerequisite = Resources.GetBlueprint<BlueprintFeature>("4ddc88f422a84f76a952e24bec7b53e1").GetComponent<PrerequisiteFeaturesFromList>();
                    ShiftersRushFeaturePrerequisite.m_Features = ShiftersRushFeaturePrerequisite.m_Features.AppendToArray(WildShapeDragonShapeBiteFeature.ToReference<BlueprintFeatureReference>());
                    ShiftersRushFeaturePrerequisite.m_Features = ShiftersRushFeaturePrerequisite.m_Features.AppendToArray(TreesingerWildShapeMandragoraFeature.ToReference<BlueprintFeatureReference>());
                }
                else { //TTT Option OFF - Shifters Rush
                    var ShiftersRushFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("4ddc88f422a84f76a952e24bec7b53e1").GetComponent<PrerequisiteCondition>().Condition;
                    var ShiftersRushFeatureConditionsChecker = ShiftersRushFeatureCondition as OrAndLogic;
                    ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions = ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                    ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions = ShiftersRushFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                }
                if (ModSupportUtilities.GetEnergizedWildShapePrerequisitesTTTBaseSetting()) { //TTT Option ON - Energized Wild Shape
                    var EnergizedWildShapeFeature = Resources.GetBlueprint<BlueprintFeature>("92df031ed2cb4153950853d6a3b9813e").GetComponent<PrerequisiteFeaturesFromList>();
                    EnergizedWildShapeFeature.m_Features = EnergizedWildShapeFeature.m_Features.AppendToArray(WildShapeDragonShapeBiteFeature.ToReference<BlueprintFeatureReference>());
                    EnergizedWildShapeFeature.m_Features = EnergizedWildShapeFeature.m_Features.AppendToArray(TreesingerWildShapeMandragoraFeature.ToReference<BlueprintFeatureReference>());
                } 
                else { //TTT Option OFF - Energized Wild Shape
                    var EnergizedWildShapeFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("92df031ed2cb4153950853d6a3b9813e").GetComponent<PrerequisiteCondition>().Condition;
                    var EnergizedWildShapeFeatureConditionsChecker = EnergizedWildShapeFeatureCondition as OrAndLogic;
                    EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions = EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                    EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions = EnergizedWildShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                }
                if (ModSupportUtilities.GetRakingClawsTTTBaseSetting()) { //TTT Option ON - Raking Claws
                    var RakingClawsFeature = Resources.GetBlueprint<BlueprintFeature>("a1b262d2b1ef478994113fc941fa3a32").GetComponent<PrerequisiteFeaturesFromList>();
                    RakingClawsFeature.m_Features = RakingClawsFeature.m_Features.AppendToArray(WildShapeDragonShapeBiteFeature.ToReference<BlueprintFeatureReference>());
                    RakingClawsFeature.m_Features = RakingClawsFeature.m_Features.AppendToArray(TreesingerWildShapeMandragoraFeature.ToReference<BlueprintFeatureReference>());
                } 
                else { //TTT Option OFF - Raking Claws
                    var RakingClawsFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("a1b262d2b1ef478994113fc941fa3a32").GetComponent<PrerequisiteCondition>().Condition;
                    var RakingClawsFeatureConditionsChecker = RakingClawsFeatureCondition as OrAndLogic;
                    RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions = RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                    RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions = RakingClawsFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                }
                if (ModSupportUtilities.GetFrightfulShapeTTTBaseSetting()) { //TTT Option ON - Frightful Shape
                    var FrightfulShapeFeature = Resources.GetBlueprint<BlueprintFeature>("8e8a34c754d649aa9286fe8ee5cc3f10").GetComponent<PrerequisiteFeaturesFromList>();
                    FrightfulShapeFeature.m_Features = FrightfulShapeFeature.m_Features.AppendToArray(WildShapeDragonShapeBiteFeature.ToReference<BlueprintFeatureReference>());
                    FrightfulShapeFeature.m_Features = FrightfulShapeFeature.m_Features.AppendToArray(TreesingerWildShapeMandragoraFeature.ToReference<BlueprintFeatureReference>());
                } 
                else { //TTT Option OFF - Frightful Shape
                    var FrightfulShapeFeatureCondition = Resources.GetBlueprint<BlueprintFeature>("8e8a34c754d649aa9286fe8ee5cc3f10").GetComponent<PrerequisiteCondition>().Condition;
                    var FrightfulShapeFeatureConditionsChecker = FrightfulShapeFeatureCondition as OrAndLogic;
                    FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions = FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = WildShapeDragonShapeBiteFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                    FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions = FrightfulShapeFeatureConditionsChecker.ConditionsChecker.Conditions.AppendToArray(
                        new ContextConditionHasFact() { Not = false, m_Fact = TreesingerWildShapeMandragoraFeature.ToReference<BlueprintUnitFactReference>() }
                        );
                }
            }


















        }
        protected static bool IsModEnabled(string modName) {
            return modEntries.Where(mod => mod.Info.Id.Equals(modName) && mod.Enabled && !mod.ErrorOnLoading).Any();
        }
    }
}
