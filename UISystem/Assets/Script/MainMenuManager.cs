using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{

    [System.Serializable]
    public class MenuButtonBudleItem
    {
        public GameObject btnItemObj;
        public GameObject node;
    }

    [System.Serializable]
    public class MainMenuManager : MonoBehaviour
    {

        [SerializeField] private MenuButtonBudleItem[] menuBtnBundleItems;
        [SerializeField] private GameObject node;

        public AudioClip MenuItemClick;
        public AudioSource audioSource;
        private void OnEnable()
        {
          
            for (int i = 0; i < menuBtnBundleItems.Length; i++)
            {
                MenuButtonItem menuBtn = menuBtnBundleItems[i].btnItemObj.GetComponent<MenuButtonItem>();
                if (menuBtn == null)
                {
                    menuBtnBundleItems[i].btnItemObj.AddComponent<MenuButtonItem>();
                    menuBtn = menuBtnBundleItems[i].btnItemObj.GetComponent<MenuButtonItem>();
                }

                menuBtn.node = menuBtnBundleItems[i].node;
            }

        }
       

        void Start()
        {
            UINavigationSystem.PushNode(node);
            audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UINavigationSystem.PopNode();
            }
        }



    }
}