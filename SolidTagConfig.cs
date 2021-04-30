namespace Useful_Tags_Lite
{
    using STRINGS;
    using System;
    using TUNING;
    using UnityEngine;

    public class SolidTagConfig : IBuildingConfig
    {
        public const string ID = "SolidTag";

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
            BuildingDef def = BuildingTemplates.CreateBuildingDef("SolidTag", 1, 2, "solid_tag_kanim", 30, 10f, singleArray1, textArray1, 1600f, BuildLocationRule.Anywhere, decor, TUNING.NOISE_POLLUTION.NONE, 0.2f);
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
            artable.stages.Add(new Artable.Stage("Default", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.NOSOLID_TAG, "off", 0, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.AGRICULTURE_TAG, "art_a", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good2", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.CONSUMORE_TAG, "art_b", 1, false, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good3", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.CRITTEREGG_TAG, "art_c", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good4", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.CULSOIL_TAG, "art_d", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good5", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.FILTRATION_TAG, "art_e", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good6", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.INDING_TAG, "art_f", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good7", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.LIQUEFIABLE_TAG, "art_g", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good8", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.MANUFACT_TAG, "art_h", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good9", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.MEDSUP_TAG, "art_i", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good10", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.METALORE_TAG, "art_j", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good11", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.MISC_TAG, "art_l", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good12", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.ORGANIC_TAG, "art_m", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good13", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.RARE_TAG, "art_n", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good14", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.RAWMINERAL_TAG, "art_o", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good15", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.REFMETAL_TAG, "art_p", 1, true, Artable.Status.Okay));
            artable.stages.Add(new Artable.Stage("Good16", (string)INTERNALSTRINGS.SOLID_ELEMENT_TAGS.REFMINERAL_TAG, "art_q", 1, true, Artable.Status.Okay));

            SelectiveTag pickable = go.AddOrGet<SelectiveTag>();
            pickable.artable = artable;
        }
    }
}
