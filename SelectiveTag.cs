using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Useful_Tags_Lite
{
    class SelectiveTag : KMonoBehaviour
    {
        public Artable artable;

        protected override void OnCleanUp()
        {
            this.Unsubscribe(493375141);
            base.OnCleanUp();
        }

        protected override void OnPrefabInit()
        {
            base.OnPrefabInit();
            this.Subscribe(493375141, new System.Action<object>(this.OnRefreshUserMenu));
        }

        private void OnNextArtClicked()
        {
            int i = artable.stages.FindIndex(s => s.id == artable.CurrentStage);
            Artable.Stage desiredStage = (i + 1 == artable.stages.Count) ? artable.stages[0] : artable.stages[i + 1];
            artable.SetStage(desiredStage.id, false);
        }

        private void OnRefreshUserMenu(object obj)
        {
            if (!((UnityEngine.Object)this.artable != (UnityEngine.Object)null))
                return;
            string nextIcon = "action_direction_right";

            Artable.Status status = artable.stages.Find(s => s.id == artable.CurrentStage).statusItem;
            int count = artable.stages.Where(s => s.statusItem == status).ToList().Count;
            if (count > 1) Game.Instance?.userMenu?.AddButton(this.gameObject, new KIconButtonMenu.ButtonInfo(nextIcon, INTERNALSTRINGS.NEXT_ART_BUTTON.TEXT, new System.Action(this.OnNextArtClicked), Action.BuildMenuKeyQ, tooltipText: ((string)INTERNALSTRINGS.NEXT_ART_BUTTON.TOOLTIP)));

        }
    }
}
