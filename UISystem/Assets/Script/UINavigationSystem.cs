using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{

    public enum STACK_OERATION
    {
        PUSH,
        POP
    }
    public  class UINavigationSystem 
    {

        public static Stack<GameObject> uINodeStack;

        public static void Init()
        {
            uINodeStack = new Stack<GameObject>();
        }
        public static void PushNode(GameObject gb)
        {
            if (uINodeStack.Count != 0)
                uINodeStack.Peek().SetActive(false);
            uINodeStack.Push(gb);

            UIAnimationSystem.Animation(gb, UIAnimationSystem.AnimationType.Jump);
            gb.SetActive(true);
        }
        public static void PopNode()
        {
           // if (uINodeStack.Count == 1) return;
            if (uINodeStack.Count > 0)
            {
                GameObject topNode = uINodeStack.Peek();
                UIAnimationSystem.Animation(topNode, UIAnimationSystem.AnimationType.Jump);
                topNode.SetActive(false);
                uINodeStack.Pop();
                if (uINodeStack.Count > 0)
                {
                    topNode = uINodeStack.Peek();
                    topNode.SetActive(true);
                }
            }

        }

       
      

    }
}