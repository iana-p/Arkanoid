using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class PanelOpener : MonoBehaviour
    {
        public GameObject panel;
        private void Start()
        {
            //OpenPanel();
        }
        //public void TogglePanel()
        //{
        //    if(panel != null)
        //    {
        //        Animator anim = panel.GetComponent<Animator>();
        //        if(anim != null)
        //        {
        //            bool isOpen = anim.GetBool("open");
        //            anim.SetBool("open", !isOpen);
        //        }
        //    }
        //}
        public void TogglePanel()
        {
            if (panel != null)
            {
                Animator anim = panel.GetComponent<Animator>();
                if (anim != null)
                {
                    bool isOpen = anim.GetBool("open");
                    anim.SetBool("open", !isOpen);
                }
            }
        }
    }
}