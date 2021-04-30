namespace Useful_Tags_Lite
{
    using STRINGS;
    using System;
    using TUNING;
    using UnityEngine;

    public class UtilityTagConfig : IBuildingConfig
    {
        public const string ID = "UtilityTag";

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
            BuildingDef def = BuildingTemplates.CreateBuildingDef("UtilityTag", 1, 1, "utility_tag_kanim", 30, 10f, singleArray1, textArray1, 1600f, BuildLocationRule.Anywhere, decor, TUNING.NOISE_POLLUTION.NONE, 0.2f);
            def.Floodable = false;
            def.SceneLayer = Grid.SceneLayer.InteriorWall;
            def.Overheatable = false;
            def.AudioCategory = "Metal";
            def.BaseTimeUntilRepair = -1f;
            def.ViewMode = OverlayModes.Decor.ID;
            def.DefaultAnimState = "off";
            def.PermittedRotations = PermittedRotations.R360;
            return def;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            Artable artable = go.AddComponent<Painting>();
            artable.stages.Add(new Artable.Stage("Default", (string)INTERNALSTRINGS.UTILITY_TAGS.NOSUT_TAG, "off", 0, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good", (string)INTERNALSTRINGS.UTILITY_TAGS.ARROW_TAG, "art_a", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good2", (string)INTERNALSTRINGS.UTILITY_TAGS.DIAGARROW_TAG, "art_b", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good3", (string)INTERNALSTRINGS.UTILITY_TAGS.BOTHARROW_TAG, "art_c", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good4", (string)INTERNALSTRINGS.UTILITY_TAGS.GASPUMP_TAG, "art_d", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good5", (string)INTERNALSTRINGS.UTILITY_TAGS.LIQUIDPUMP_TAG, "art_e", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good6", (string)INTERNALSTRINGS.UTILITY_TAGS.SOLIDCON_TAG, "art_f", 1, true, Artable.Status.Okay));

            SelectiveTag pickable = go.AddOrGet<SelectiveTag>();
            pickable.artable = artable;
        }
    }
}
