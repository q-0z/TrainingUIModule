using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{
    public enum MENU_ITEM_TYPE
    {
        TOGGLE,
        SLIDER,
        DROPDOWN
    }

    [System.Serializable]
    public class TabContentMenuItem<T>
    {
        public string id;
        public MENU_ITEM_TYPE itemType;
        public T value;
    }


    [CreateAssetMenu()]
    public class GameSettings : ScriptableObject
    {

        public TabContentMenuItem<float>[] menuItemData;
        [SerializeField] public ContentPanelSlot contentPanelObj;


        // public bool vSync = false;
        //   public bool shadow = false;
    }
}