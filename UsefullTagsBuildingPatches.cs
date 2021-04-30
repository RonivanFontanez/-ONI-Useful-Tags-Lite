namespace Useful_Tags_Lite
{
    using Harmony;
    using System;
    using UnityEngine;

    //===> SELECTIVE TAG PATCH <===================================================================
    public class Patches
    {
        public static class Mod_OnLoad
        {
            public static void OnLoad()
            {
                // Change this message to whatever makes sense
                // I used it to ensure correct code version is executed
                Debug.Log("Useful Tags Lite: Loaded v.1.0");
            }
        }
    }

    //===> DANGER RIBBON CORNER <===============================================================================
    namespace DangerRibbonCornerUIPatch
    {
        using Harmony;
        using STRINGS;
        using System;

        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class DangerRibbonCornerUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.DANGERRIBBONCORNER.NAME", "Danger Ribbon Corner Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.DANGERRIBBONCORNER.DESC", "A wall tag with a danger ribbon mark for corners." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.DANGERRIBBONCORNER.EFFECT";
                string[] textArray4 = new string[] { "This tag serves to demark a corner segment of a dangerous ribbon line." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "DangerRibbonCorner");
            }
        }
    }

    //===> DANGER RIBBON <===============================================================================
    namespace DangerRibbonUIPatch
    {
        using Harmony;
        using STRINGS;
        using System;

        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class DangerRibbonUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.DANGERRIBBON.NAME", "Danger Ribbon Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.DANGERRIBBON.DESC", "A wall tag with a danger ribbon mark." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.DANGERRIBBON.EFFECT";
                string[] textArray4 = new string[] { "This tag serves to demark a straight line used to outline a dangerous area." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "DangerRibbon");
            }
        }
    }

    //===> METER SCALE  <==============================================================================
    namespace Meter_ScaleUIPatch
    {
        using Harmony;
        using STRINGS;
        using System;

        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class Meter_ScaleUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.METER_SCALE.NAME", "Meter Scale Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.METER_SCALE.DESC", "A wall meter scale used in open liquid reservoirs." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.METER_SCALE.EFFECT";
                string[] textArray4 = new string[] { "This scale tag is often used to measure the amount of liquid in a reservoir." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "Meter_Scale");
            }
        }
    }

    //===> INFO TAG <=============================================================================
    namespace InfoTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class InfoTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.INFOTAG.NAME", "Info Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.INFOTAG.DESC", "A wall tag for directive environmental information." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.INFOTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation many different directive informations regarding environment. Select the type of directive using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "InfoTag");
            }
        }
    }

    //===> SYSTEM TAG <=============================================================================
    namespace SystemTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class SystemTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.SYSTEMTAG.NAME", "System Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.SYSTEMTAG.DESC", "A wall informative tag for system and sensors." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.SYSTEMTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of many different kinds of eletronics, systems and sensors signs. Select the type of system using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "SystemTag");
            }
        }
    }

    //===> UTILITY TAG <=============================================================================
    namespace UtilityTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class UtilityTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.UTILITYTAG.NAME", "Utility Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.UTILITYTAG.DESC", "A wall informative tag for utilities." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.UTILITYTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of many different kinds of utilities signs. Select the type of utility using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "UtilityTag");
            }
        }
    }

    //===> ALERT TAG <=============================================================================
    namespace AlertTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class AlertTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.ALERTTAG.NAME", "Alert Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.ALERTTAG.DESC", "A wall informative tag for alerts." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.ALERTTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of many different alerts. Select the type of alert using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "AlertTag");
            }
        }
    }

    //===> SOLID TAG <=============================================================================
    namespace SolidTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class SolidTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.SOLIDTAG.NAME", "Solid Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.SOLIDTAG.DESC", "A wall informative tag for solids." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.SOLIDTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of solids in an industrial environment. Select the type of solids using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "SolidTag");
            }
        }
    }

    //===> LIQUID TAG <=============================================================================
    namespace LiquidTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class LiquidTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.LIQUIDTAG.NAME", "Liquid Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.LIQUIDTAG.DESC", "A wall informative tag for liquids." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.LIQUIDTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of liquids in an industrial environment. Select the type of liquid using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "LiquidTag");
            }
        }
    }

    //===> GAS TAG <===============================================================================
    namespace GasTagUIPatch
    {
        [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
        internal class GasTagUI
        {
            private static void Prefix()
            {
                string[] textArray1 = new string[] { "STRINGS.BUILDINGS.PREFABS.GASTAG.NAME", "Gas Tag" };
                Strings.Add(textArray1);
                string[] textArray2 = new string[] { "STRINGS.BUILDINGS.PREFABS.GASTAG.DESC", "A wall informative tag for gases." };
                Strings.Add(textArray2);
                string[] textArray3 = new string[2];
                textArray3[0] = "STRINGS.BUILDINGS.PREFABS.GASTAG.EFFECT";
                string[] textArray4 = new string[] { "This tag is a visual representation of gases in an industrial environment. Select the type of gas using the menu option." };
                textArray3[1] = string.Concat(textArray4);
                Strings.Add(textArray3);
                ModUtil.AddBuildingToPlanScreen("Utilities", "GasTag");
            }
        }
    }

}
