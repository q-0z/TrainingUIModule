using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UISystem
{
    public class MenuButtonItem : ButtonItem
    {

        [SerializeField] public GameObject node;
        [SerializeField] protected STACK_OERATION stackOperation=STACK_OERATION.PUSH;
        public delegate void SetCallback();
        public event SetCallback SetOnclickCallBackEvent;

        private void Awake()
        {
            UINavigationSystem.Init();
        }
        protected override void Start()
        {
            base.Start();

        }

        public override void OnClickCallback()
        {
            base.OnClickCallback();
            Panel(true);
            SetOnclickCallBackEvent?.Invoke();
        }


        public void Panel(bool active)
        {
            if (stackOperation != STACK_OERATION.POP)
            {
                node.gameObject.SetActive(active);
                UINavigationSystem.PushNode(node);
            }
            else
                UINavigationSystem.PopNode();

           

        }

    }
}
