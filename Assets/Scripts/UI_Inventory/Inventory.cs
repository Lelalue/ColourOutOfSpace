using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlienColour.Assets.Scripts.UI_Inventory
{


    // https://www.youtube.com/watch?v=Hj7AZkyojdo&list=PLboXykqtm8dynMisqs4_oKvAIZedixvtf


    public class Inventory : MonoBehaviour
    {
        public Collector collector;

        void Start()
        {
            collector.ItemAdded += Script_ItemAdded;
        }

        private void Script_ItemAdded(object sender, InventoryEventHandler e)
        {
            Transform iPanel = this.gameObject.transform;
            foreach (Transform slot in iPanel)
            {
                Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

                if (!image.enabled)
                {
                    image.enabled = true;
                    image.sprite = e.Item.Image;
                   
                    break;
                }

            }
        }
    }   
}