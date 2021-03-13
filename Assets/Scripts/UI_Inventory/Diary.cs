using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Diary : MonoBehaviour, IInventoryItem
    {
        public IDisplay display;

        public void Awake()
        {
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }


        public string Name
        {
            get
            {
                return "diary";
            }
        }
        public Sprite _Image = null;

        public Sprite Image
        {
            get
            {
                return _Image;
            }
        }

        public void OnPickUp()
        {
            display.SetText(Name);
        }
    }
}