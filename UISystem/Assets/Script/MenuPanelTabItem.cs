using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UISystem
{
    public class MenuPanelTabItem : ButtonItem
    {
        RectTransform rectTransform;

        public delegate void OnButtonClickDelegate();
        public event OnButtonClickDelegate OnButtonClickEvent;
        protected override void Start()
        {
            base.Start();
            rectTransform = transform.parent.GetComponent<RectTransform>();

        }
        public override void OnClickCallback()
        {
            base.OnClickCallback();
            UIAnimationSystem.Animation(gameObject, UIAnimationSystem.AnimationType.Shake);
            rectTransform.SetAsLastSibling();

            OnButtonClickEvent?.Invoke();

        }

    }
}