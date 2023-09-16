﻿using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using ExpandedContent.Extensions;
using ExpandedContent.Config;

namespace ExpandedContent.Tweaks.RacialArchetypes {
    internal class Stonelord {

        
                
        public static void AllowStonelordArchetype() {

                    if (ModSettings.AddedContent.RacialArchetypes.IsDisabled("StonelordArchetype")) { return; }
                    BlueprintArchetype StonelordArchetype = Resources.GetBlueprint<BlueprintArchetype>("cf0f99b3cd7444a48681b1c1c4aa2a41");
                    StonelordArchetype.RemoveComponents<PrerequisiteFeature>();
            





                
        }

            
    }
        
}

    
