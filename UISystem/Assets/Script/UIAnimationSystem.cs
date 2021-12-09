using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace UISystem
{
    public class UIAnimationSystem : MonoBehaviour
    {
        public enum AnimationType
        {
            Scale,
            Jump,
            Shake
        }
        public static void Animation(GameObject gb, AnimationType type)
        {
            if (type == AnimationType.Scale)
            {
                gb.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                gb.transform.DOScale(1, 0.1f);
            }
            if (type == AnimationType.Shake)
            {
                gb.transform.DOShakePosition(0.5f, 30, 30);
            }
            if (type == AnimationType.Jump)
            {
                gb.transform.position = new Vector3(gb.transform.position.x, gb.transform.position.y - 70, gb.transform.position.z);
                gb.transform.DOMoveY(gb.transform.position.y + 70, 0.5f);
            }
        }
    }
}