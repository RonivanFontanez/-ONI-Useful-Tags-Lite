namespace Useful_Tags_Lite
{
    using STRINGS;
    using System;
    using TUNING;
    using UnityEngine;

    public class Meter_ScaleConfig : IBuildingConfig
    {
        public const string ID = "Meter_Scale";

        public override void ConfigureBuildingTemplate(GameObject go, Tag prefab_tag)
        {
            go.AddOrGet<BuildingComplete>().isArtable = true;
            go.GetComponent<KPrefabID>().AddTag(GameTags.Decoration, false);
        }

        public override BuildingDef CreateBuildingDef()
        {
            float[] singleArray1 = new float[] { 10f };
            string[] textArray1 = new string[] { "BuildableRaw" };
            EffectorValues nONE = NOISE_POLLUTION.NONE;
            BuildingDef def1 = BuildingTemplates.CreateBuildingDef("Meter_Scale", 1, 1, "tag_scale_kanim", 30, 30f, singleArray1, textArray1, 1600f, BuildLocationRule.Anywhere, nONE, TUNING.NOISE_POLLUTION.NONE, 0.2f);
            def1.Floodable = false;
            def1.SceneLayer = Grid.SceneLayer.InteriorWall;
            def1.Overheatable = false;
            def1.AudioCategory = "Metal";
            def1.BaseTimeUntilRepair = -1f;
            def1.DefaultAnimState = "off";
            return def1;
        }

        public override void DoPostConfigureComplete(GameObject go)
        {
            GeneratedBuildings.RemoveLoopingSounds(go);
        }
    }
}
