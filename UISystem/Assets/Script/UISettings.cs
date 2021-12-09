using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{
    [CreateAssetMenu()]
    public class UISettings : ScriptableObject
    {
        public AudioClip MenuItemClick;
        public AudioSource _audioSource;
    }
}