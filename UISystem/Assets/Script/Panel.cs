using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace UISystem
{
    [System.Serializable]
    public class PanelMenu
    {
        [SerializeField] public GameObject menuPanelTabItem;
        [SerializeField] public GameObject panelContentObj;
        [SerializeField] public GameSettings settings;
    }
    public class Panel : MonoBehaviour
    {
        [SerializeField] private PanelMenu [] panelMenus;

        private void Start()
        {
            foreach (PanelMenu panelMenu in panelMenus)
            {
                MenuPanelTabItem tabItem =panelMenu.menuPanelTabItem.GetComponent<MenuPanelTabItem>();
                if (tabItem == null)
                {
                    panelMenu.menuPanelTabItem.AddComponent<MenuPanelTabItem>();
                    tabItem = panelMenu.menuPanelTabItem.GetComponent<MenuPanelTabItem>();
                }

                PanelContentItem panelCont = panelMenu.panelContentObj.GetComponent<PanelContentItem>();
                if (panelCont == null)
                {
                    panelMenu.panelContentObj.AddComponent<PanelContentItem>();
                    panelCont = panelMenu.panelContentObj.GetComponent<PanelContentItem>();
                    panelCont.settings = panelMenu.settings;


                    panelCont.Init();
                }
            }
        }
    }
}