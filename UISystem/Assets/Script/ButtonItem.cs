using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UISystem
{
    public abstract class ButtonItem : MonoBehaviour, IButtonItem
    {
        int uiElementId;
        Button button;

         AudioClip btnClickSoundClick;
         private AudioSource audioSource;
        protected virtual void Start()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClickCallback);
            audioSource = FindObjectOfType<MainMenuManager>().audioSource;
            btnClickSoundClick = FindObjectOfType<MainMenuManager>().MenuItemClick;
        }

        public virtual void OnClickCallback()
        {
            PlayAudio();
        }

        public void SetId(int id)
        {
            uiElementId = id;
        }
        public int GetId()
        {
            return uiElementId;
        }
        protected virtual void PlayAudio()
        {
            audioSource.PlayOneShot(btnClickSoundClick);

        }
    }
}