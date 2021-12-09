using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace UISystem
{ 
    public enum PANEL_MENU_OPTION_TYPE
    {
        None,
        Toggle,
        Slider,
        DropDown

    }
    public class PanelContentItem : PanelContent
    {

        private GameSettings _settings;

        public GameSettings settings{  set { _settings = value; } }

        public void Init()
        {
            foreach (var settingSlotObj in _settings.menuItemData)
            {

                var obj = Instantiate(_settings.contentPanelObj, transform.GetChild(0));


                obj.settingVariableName.text = settingSlotObj.id + "";
                if (settingSlotObj.itemType == MENU_ITEM_TYPE.TOGGLE)
                {
                    obj.settingVariableToggle.gameObject.SetActive(true);
                    obj.settingVariableSlider.gameObject.SetActive(false);
                    obj.settingVariableToggle.isOn = settingSlotObj.value == 1f ? true : false;

                }
                if (settingSlotObj.itemType == MENU_ITEM_TYPE.SLIDER)
                {
                    obj.settingVariableToggle.gameObject.SetActive(false);
                    obj.settingVariableSlider.gameObject.SetActive(true);
                    obj.settingVariableSlider.value = settingSlotObj.value;
                }

            }
        }
      

    }
}