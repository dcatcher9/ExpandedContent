﻿using ExpandedContent.Extensions;
using ExpandedContent.Utilities;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Blueprints.Items;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Alignments;
using Kingmaker.UnitLogic.FactLogic;

namespace ExpandedContent.Tweaks.Deities {
    internal class Olheon {
        private static readonly BlueprintFeature GoodDomainAllowed = Resources.GetBlueprint<BlueprintFeature>("882521af8012fc749930b03dc18a69de");
        private static readonly BlueprintFeature LawDomainAllowed = Resources.GetBlueprint<BlueprintFeature>("092714336606cfc45a37d2ab39fabfa8");
        private static readonly BlueprintFeature NobilityDomainAllowed = Resources.GetBlueprint<BlueprintFeature>("e0471d01e73254a4ca23278705b75e57");
        private static readonly BlueprintFeature ProtectionDomainAllowed = Resources.GetBlueprint<BlueprintFeature>("d4ce7592bd12d63439907ad64e986e59");
        private static readonly BlueprintFeature ArchonDomainGoodAllowed = Resources.GetModBlueprint<BlueprintFeature>("ArchonDomainGoodAllowed");
        private static readonly BlueprintFeature ArchonDomainLawAllowed = Resources.GetModBlueprint<BlueprintFeature>("ArchonDomainLawAllowed");
        private static readonly BlueprintFeature DefenseDomainAllowed = Resources.GetModBlueprint<BlueprintFeature>("DefenseDomainAllowed");
        private static readonly BlueprintSpellbook CrusaderSpellbook = Resources.GetBlueprint<BlueprintSpellbook>("673d39f7da699aa408cdda6282e7dcc0");
        private static readonly BlueprintSpellbook ClericSpellbook = Resources.GetBlueprint<BlueprintSpellbook>("4673d19a0cf2fab4f885cc4d1353da33");
        private static readonly BlueprintSpellbook InquisitorSpellbook = Resources.GetBlueprint<BlueprintSpellbook>("57fab75111f377248810ece84193a5a5");
        private static readonly BlueprintFeature ChannelPositiveAllowed = Resources.GetBlueprint<BlueprintFeature>("8c769102f3996684fb6e09a2c4e7e5b9");
        private static readonly BlueprintCharacterClass ClericClass = Resources.GetBlueprint<BlueprintCharacterClass>("67819271767a9dd4fbfd4ae700befea0");
        private static readonly BlueprintCharacterClass InquistorClass = Resources.GetBlueprint<BlueprintCharacterClass>("f1a70d9e1b0b41e49874e1fa9052a1ce");
        private static readonly BlueprintCharacterClass WarpriestClass = Resources.GetBlueprint<BlueprintCharacterClass>("30b5e47d47a0e37438cc5a80c96cfb99");
        private static readonly BlueprintCharacterClass PaladinClass = Resources.GetBlueprint<BlueprintCharacterClass>("bfa11238e7ae3544bbeb4d0b92e897ec");
        private static readonly BlueprintFeature MythicIgnoreAlignmentRestrictions = Resources.GetBlueprint<BlueprintFeature>("24e78475f0a243e1a810452d14d0a1bd");



        public static void AddOlheonFeature() {

            BlueprintItem MasterworkGlaive = Resources.GetBlueprint<BlueprintItem>("3ddb7cda73d48874d8270212a0d052dd");

            BlueprintArchetype FeralChampionArchetype = Resources.GetBlueprint<BlueprintArchetype>("f68ca492c9c15e241ab73735fbd0fb9f");
            BlueprintArchetype PriestOfBalance = Resources.GetBlueprint<BlueprintArchetype>("a4560e3fb5d247d68fb1a2738fcc0855");
            BlueprintArchetype SilverChampionArchetype = Resources.GetModBlueprint<BlueprintArchetype>("SilverChampionArchetype");
            BlueprintArchetype SwornOfTheEldestArchetype = Resources.GetModBlueprint<BlueprintArchetype>("SwornOfTheEldestArchetype");

            BlueprintFeature GlaiveProficiency = Resources.GetBlueprint<BlueprintFeature>("38d4d143e7f293249b72694ddb1e0a32");
            var OlheonIcon = AssetLoader.LoadInternal("Deities", "Icon_Olheon.jpg");
            var OlheonFeature = Helpers.CreateBlueprint<BlueprintFeature>("OlheonFeature", (bp => {

                bp.SetName("Olheon");
                bp.SetDescription("\nTitles: The Just Arbiter   " +
                    "\nAlignment: Lawful Good   " +
                    "\nAreas of Concern: Deservedness, Nobility, Rulership   " +
                    "\nDomains: Good, Law, Nobility, Protection   " +
                    "\nSubdomains: Archon, Defense, Leadership, Martyr   " +
                    "\nFavoured Weapon: Halberd (Glaive)   " +
                    "\nHoly Symbol: Figure framed by branches   " +
                    "\nSacred Animal: Wolf   " +
                    "\nIt is said that Olheon knows the lineage of every noble soul in existence. She tracks the passage of power-and the responsibilities " +
                    "such power brings with it-from parent to child, ruler to heir, and dynasty to dynasty. Whether power transfers legitimately through " +
                    "inheritance or election or forcibly through coup or rebellion, Olheon sees the change and judges accordingly. The Just Arbiter is among " +
                    "the most magnificent empyreal lords to behold. Olheon stands over 16 feet tall, towering over most mortals, and her blue eyes blaze in a " +
                    "face of burnished gold. She wears a heavy silver breastplate and greaves, but her gauntleted hands and forearms are stained crimson, as if " +
                    "she had plunged her armored fists into pools of fresh blood. In one hand she carries a ruby-bladed halberd even taller than herself; in the " +
                    "other hand, she bears a heavy golden seal of office affirming her charge. Olheon despises tyrants and boils at the sight of legitimate rulers " +
                    "who, through weakness or ignorance, cause hardship and unjust living conditions for those under their dominion. She works through her subjects " +
                    "and divine minions to teach those who can be taught and to punish those who cannot. Officials, noble rulers, and even parents all look to " +
                    "Olheon for guidance, and they are in turn judged according to their actions. Olheon occupies the northern wing of the Courts of Accord, where the " +
                    "magicals crying mirrors hung in her vast Hall of Thrones displays cenes of accession and rulership throughout the multiverse.");
                bp.m_Icon = OlheonIcon;
                bp.Ranks = 1;
                bp.IsClassFeature = true;
                bp.HideInCharacterSheetAndLevelUp = false;
                bp.AddComponent<PrerequisiteNoArchetype>(c => {
                    c.m_CharacterClass = ClericClass.ToReference<BlueprintCharacterClassReference>();
                    c.m_Archetype = PriestOfBalance.ToReference<BlueprintArchetypeReference>();
                });
                bp.AddComponent<PrerequisiteNoArchetype>(c => {
                    c.m_CharacterClass = WarpriestClass.ToReference<BlueprintCharacterClassReference>();
                    c.m_Archetype = FeralChampionArchetype.ToReference<BlueprintArchetypeReference>();
                });
                bp.AddComponent<PrerequisiteNoArchetype>(c => {
                    c.HideInUI = true;
                    c.m_CharacterClass = PaladinClass.ToReference<BlueprintCharacterClassReference>();
                    c.m_Archetype = SilverChampionArchetype.ToReference<BlueprintArchetypeReference>();
                });
                bp.AddComponent<PrerequisiteNoArchetype>(c => {
                    c.HideInUI = true;
                    c.m_CharacterClass = InquistorClass.ToReference<BlueprintCharacterClassReference>();
                    c.m_Archetype = SwornOfTheEldestArchetype.ToReference<BlueprintArchetypeReference>();
                });
                bp.Groups = new FeatureGroup[] { FeatureGroup.Deities };
                bp.AddComponent<PrerequisiteAlignment>(c => {
                    c.Alignment = AlignmentMaskType.LawfulGood | AlignmentMaskType.NeutralGood | AlignmentMaskType.LawfulNeutral;
                });
                bp.AddComponent<AddFacts>(c => {
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        ChfannelNegativeAllowed.ToReference<BlueprintUnitFactReference>(),
                        EviflDomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        LawDfomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        AirDofmainAllowed.ToReference<BlueprintUnitFactReference>(),
                        DeathDfomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        DeathDfomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        DeathDfomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        DeathDfomainAllowed.ToReference<BlueprintUnitFactReference>(),
                        WindDomfainAllowed.ToReference<BlueprintUnitFactReference>(),
                        UndeadDofmainAllowed.ToReference<BlueprintUnitFactReference>()
                    };
                });
                bp.AddComponent<ForbidSpellbookOnAlignmentDeviation>(c => {
                    c.m_Spellbooks = new BlueprintSpellbookReference[] {
                        CrusaderSpellbook.ToReference<BlueprintSpellbookReference>(),
                        ClericSpellbook.ToReference<BlueprintSpellbookReference>(),
                        InquisitorSpellbook.ToReference<BlueprintSpellbookReference>()
                    };
                    c.m_IgnoreFact = MythicIgnoreAlignmentRestrictions.ToReference<BlueprintUnitFactReference>();
                    c.Alignment = gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg;
                });
                bp.AddComponent<AddFeatureOnClassLevel>(c => {
                    c.m_Class = ClericClass.ToReference<BlueprintCharacterClassReference>();


                    c.m_Feature = GlaiveProficiency.ToReference<BlueprintFeatureReference>();

                    c.Level = 1;
                    c.m_Archetypes = null;
                    c.m_AdditionalClasses = new BlueprintCharacterClassReference[2] {
                               InquistorClass.ToReference<BlueprintCharacterClassReference>(),
                               WarpriestClass.ToReference<BlueprintCharacterClassReference>() };
                });
                bp.AddComponent<AddStartingEquipment>(c => {
                    c.m_BasicItems = new BlueprintItemReference[1] { MasterworkGlaive.ToReference<BlueprintItemReference>() };
                    c.m_RestrictedByClass = new BlueprintCharacterClassReference[3] {
                                ClericClass.ToReference<BlueprintCharacterClassReference>(),
                                InquistorClass.ToReference<BlueprintCharacterClassReference>(),
                                WarpriestClass.ToReference<BlueprintCharacterClassReference>()
                    };
                });
            }));

        }
    }

}
