﻿using ExpandedContent.Extensions;
using ExpandedContent.Utilities;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.UnitLogic.Alignments;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.Blueprints.Classes.Selection;

namespace ExpandedContent.Tweaks.Deities {
    internal class PatchPulura {


        private static readonly BlueprintFeature GoodDomainAllowed = Resources.GetBlueprint<BlueprintFeature>("882521af8012fc749930b03dc18a69de");
        private static readonly BlueprintFeature StarsDomainAllowed = Resources.GetModBlueprint<BlueprintFeature>("StarsDomainAllowed");
        private static readonly BlueprintCharacterClass InquistorClass = Resources.GetBlueprint<BlueprintCharacterClass>("f1a70d9e1b0b41e49874e1fa9052a1ce");



        public static void AddPulura() {

                    var PuluraIcon = AssetLoader.LoadInternal("Deities", "Icon_Pulura.jpg");
            BlueprintArchetype SwornOfTheEldestArchetype = Resources.GetModBlueprint<BlueprintArchetype>("SwornOfTheEldestArchetype");


            var PuluraFeature = Resources.GetBlueprint<BlueprintFeature>("ebb0b46f95dbac74681c78aae895dbd0");
                       PuluraFeature.SetDescription("\nTitles: The Shimmering Maiden, The North Star, Mistress of the Stars, Light of the Aurora  " +
                            "\nAlignment: Chaotic Good   " +
                            "\nAreas of Concern: Constellations, Homesickness, Northern Lights" +
                            "\nDomains: Air, Chaos, Good, Weather   " +
                            "\nSubdomains: Azata, Cloud, Seasons, Stars   " +
                            "\nFavoured Weapon: Sling" +
                            "\nHoly Symbol: Face in Northern Lights   " +
                            "\nSacred Animal: Firefly   " +
                            "\nSacred Colour: Midnight Blue   " +
                            "\nPulura, the mistress of the stars and the aurora, is an angel empyreal lord, the patron of those travellers that become homesick, " +
                            "lost, or injured in the snowy wastes of the far north." +
                            "Pulura was worshiped as a major deity in the lost Kellid realm of Sarkoris. The Sarkorians saw her and the demon lord Kostchtchie as " +
                            "dualistic gods of cold. She was honoured by a mighty ring of idols in the city of Dyinglight but, in common with the rest of Sarkoris, " +
                            "the city fell to the demons of the Worldwound. A cascade named for her, Pulura's Fall, once flowed to the northeast of Iz; it has since " +
                            "been swallowed by the Worldwound, but its namesake, a temple to Pulura, remains, and has been withstanding a demonic siege for more than a " +
                            "century. An idol to Pulura stands on the Walk of Lost Gods in the ravaged town of Gundrun." +
                            "\nAppearance: Pulura appears as a lovely, alluring Tian woman with the grace of a dancer, a gravity about her expression, and black, " +
                            "flowing hair gleaming with the light of stars. Her robes appear to be made from green and pink light, and flicker with every one of her movements. " +
                            "She often appears dancing amid the aurora borealis in the skies of far northern lands, and legend has it that her extraordinary beauty will burn " +
                            "any mortals who dare approach her too closely. She wields a sling made from sighs that fires bullets of starlight.");


            PuluraFeature.AddComponent<PrerequisiteNoArchetype>(c => {
                c.HideInUI = true;
                c.m_CharacterClass = InquistorClass.ToReference<BlueprintCharacterClassReference>();
                c.m_Archetype = SwornOfTheEldestArchetype.ToReference<BlueprintArchetypeReference>();
            });



            PuluraFeature.RemoveComponents<PrerequisiteAlignment>();


            PuluraFeature.AddComponent<PrerequisiteAlignment>(c => {
                c.Alignment = AlignmentMaskType.NeutralGood | AlignmentMaskType.ChaoticGood | AlignmentMaskType.ChaoticNeutral;
            });

            PuluraFeature.AddComponent<AddFacts>(bp => {                        
                bp.m_Facts = new BlueprintUnitFactReference[] { GoodDomainAllowed.ToReference<BlueprintUnitFactReference>() };                    
            });
            PuluraFeature.AddComponent<AddFacts>(bp => {
                bp.m_Facts = new BlueprintUnitFactReference[1] { StarsDomainAllowed.ToReference<BlueprintUnitFactReference>() };
            });
            PuluraFeature.m_Icon = PuluraIcon;
                    
                    
                    
            PuluraFeature.RemoveComponents<PrerequisiteNoFeature>();
            var EmpyrealLordSelection = Resources.GetModBlueprint<BlueprintFeatureSelection>("EmpyrealLordSelection");
            


        }
                
            
    }
        
}
    

