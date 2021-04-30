namespace Useful_Tags_Lite
{
    using STRINGS;
    using System;
    using TUNING;
    using UnityEngine;

    public class SystemTagConfig : IBuildingConfig
    {
        public const string ID = "SystemTag";

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<BuildingComplete>().isArtable = true;
            go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }

        public override BuildingDef CreateBuildingDef()
        {
            float[] singleArray1 = new float[] { 10f };
            string[] textArray1 = new string[] { "BuildableRaw" };

            EffectorValues decor = NOISE_POLLUTION.NONE;
            BuildingDef def = BuildingTemplates.CreateBuildingDef("SystemTag", 1, 1, "system_tag_kanim", 30, 10f, singleArray1, textArray1, 1600f, BuildLocationRule.Anywhere, decor, TUNING.NOISE_POLLUTION.NONE, 0.2f);
            def.Floodable = false;
            def.SceneLayer = Grid.SceneLayer.InteriorWall;
            def.Overheatable = false;
            def.AudioCategory = "Metal";
            def.BaseTimeUntilRepair = -1f;
            def.ViewMode = OverlayModes.Decor.ID;
            def.DefaultAnimState = "off";
            return def;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            Artable artable = go.AddComponent<Painting>();
            artable.stages.Add(new Artable.Stage("Default", (string)INTERNALSTRINGS.SYSTEM_TAGS.NOSYS_TAG, "off", 0, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good", (string)INTERNALSTRINGS.SYSTEM_TAGS.CLOSEDCY_TAG, "art_a", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good2", (string)INTERNALSTRINGS.SYSTEM_TAGS.ORGANICCY_TAG, "art_b", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good3", (string)INTERNALSTRINGS.SYSTEM_TAGS.RECYCLE_TAG, "art_c", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good4", (string)INTERNALSTRINGS.SYSTEM_TAGS.POWER_TAG, "art_d", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good5", (string)INTERNALSTRINGS.SYSTEM_TAGS.GASSEN_TAG, "art_e", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good6", (string)INTERNALSTRINGS.SYSTEM_TAGS.LIQUIDSEN_TAG, "art_f", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good7", (string)INTERNALSTRINGS.SYSTEM_TAGS.MOTIONSEN_TAG, "art_g", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good8", (string)INTERNALSTRINGS.SYSTEM_TAGS.POWERSEN_TAG, "art_h", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good9", (string)INTERNALSTRINGS.SYSTEM_TAGS.PRESSURESEN_TAG, "art_i", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good10", (string)INTERNALSTRINGS.SYSTEM_TAGS.TEMPSEN_TAG, "art_j", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good11", (string)INTERNALSTRINGS.SYSTEM_TAGS.TIMESEN_TAG, "art_l", 1, true, Artable.Status.Okay));

            SelectiveTag pickable = go.AddOrGet<SelectiveTag>();
            pickable.artable = artable;
        }
    }
}
