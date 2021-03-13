using AlienColour.Assets.Scripts.Interactables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Letter : MonoBehaviour, IInventoryItem
    {
        public IDisplay display;
        
        public string Name
        {
            get
            {
                return "letter";
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

        public void Awake()
        {
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }

        public void OnPickUp()
        {
            display.SetText(Name);
        }
    }
}