using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using AlienColour.Assets.Scripts.Interactables;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using AlienColour.Assets.Scripts.SelectionManager;
using System;
using System.Collections.Generic;
using AlienColour.Assets.Scripts.Sound;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
     
      public class ItemImage : MonoBehaviour
    {

        public IDisplay display;
        private Sprite sprite;

        public void Awake()
        {
            display = transform.parent.parent.parent.parent.gameObject.GetComponent<IDisplay>();
        }

        public void LeftClick()
        { 
            sprite = GetComponent<Image>().sprite;

            Debug.Log("Click");
            switch (sprite.name)
            {
                case "letter":
                        Debug.Log("ImageViewer aktivieren");
                        if (!ImageViewer.imV.ivCanvas.gameObject.activeInHierarchy)
                        {
                        //AudioManager.Instance.PlaySfx(letter);
                            ImageViewer.imV.ivCanvas.Activate(ImageViewer.imV.pic);
                        }
                    break;

                case "diary":
                        Debug.Log("ImageViewer aktivieren");
                        if (!ImageViewer.imV.ivCanvas.gameObject.activeInHierarchy)
                        {
                            ImageViewer.imV.ivCanvas.Activate(ImageViewer.imV.pic2);
                        }
                    break;

                default: 
                        display.SetText(sprite.name);
                    break;

            }
  

        }
       
    }
}