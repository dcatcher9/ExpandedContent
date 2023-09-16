﻿using ExpandedContent.Extensions;
using ExpandedContent.Utilities;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.Blueprints;

namespace ExpandedContent.Tweaks.DemonLords {
    internal class Baphomet
    {




        public static void AddBaphomet()
        {

            var BaphometIcon = AssetLoader.LoadInternal("Deities", "Icon_Baphomet.jpg");
            var BaphometFeature = Resources.GetBlueprint<BlueprintFeature>("bd72ca8ffcfec5745899ac56c93f12c5");
            var DemonDomainChaosAllowed = Resources.GetModBlueprint<BlueprintFeature>("DemonDomainChaosAllowed");
            var DemonDomainEvilAllowed = Resources.GetModBlueprint<BlueprintFeature>("DemonDomainEvilAllowed");
            var FerocityDomainAllowed = Resources.GetModBlueprint<BlueprintFeature>("FerocityDomainAllowed");
            var ResolveDomainAllowed = Resources.GetModBlueprint<BlueprintFeature>("ResolveDomainAllowed");
            var FurDomainAllowed = Resources.GetModBlueprint<BlueprintFeature>("FurDomainAllowed");
            var DreadKnightClass = Resources.GetModBlueprint<BlueprintCharacterClass>("DreadKnightClass");
            var ClawOfTheFalseWyrmArchetype = Resources.GetModBlueprint<BlueprintArchetype>("ClawOfTheFalseWyrmArchetype");
            var InquistorClass = Resources.GetBlueprint<BlueprintCharacterClass>("f1a70d9e1b0b41e49874e1fa9052a1ce");
            var SwornOfTheEldestArchetype = Resources.GetModBlueprint<BlueprintArchetype>("SwornOfTheEldestArchetype");
            var MythicIgnoreAlignmentRestrictions = Resources.GetBlueprint<BlueprintFeature>("24e78475f0a243e1a810452d14d0a1bd");

            BaphometFeature.m_Icon = BaphometIcon;
            BaphometFeature.RemoveComponents<PrerequisiteNoFeature>();
            BaphometFeature.AddComponent<PrerequisiteNoArchetype>(c => {
                c.HideInUI = true;
                c.m_CharacterClass = DreadKnightClass.ToReference<BlueprintCharacterClassReference>();
                c.m_Archetype = ClawOfTheFalseWyrmArchetype.ToReference<BlueprintArchetypeReference>();
            });
            BaphometFeature.AddComponent<PrerequisiteNoArchetype>(c => {
                c.HideInUI = true;
                c.m_CharacterClass = InquistorClass.ToReference<BlueprintCharacterClassReference>();
                c.m_Archetype = SwornOfTheEldestArchetype.ToReference<BlueprintArchetypeReference>();
            });
            BaphometFeature.AddComponent<AddFacts>(c => {
                c.m_Facts = new BlueprintUnitFactReference[1] { DemonDomainChaosAllowed.ToReference<BlueprintUnitFactReference>() };
            });
            BaphometFeature.AddComponent<AddFacts>(c => {
                c.m_Facts = new BlueprintUnitFactReference[1] { DemonDomainEvilAllowed.ToReference<BlueprintUnitFactReference>() };
            });
            BaphometFeature.AddComponent<AddFacts>(c => {
                c.m_Facts = new BlueprintUnitFactReference[1] { FerocityDomainAllowed.ToReference<BlueprintUnitFactReference>() };
            });
            BaphometFeature.AddComponent<AddFacts>(c => {
                c.m_Facts = new BlueprintUnitFactReference[1] { ResolveDomainAllowed.ToReference<BlueprintUnitFactReference>() };
            });
            BaphometFeature.AddComponent<AddFacts>(c => {
                c.m_Facts = new BlueprintUnitFactReference[1] { FurDomainAllowed.ToReference<BlueprintUnitFactReference>() };
            });
        }


    }

}


