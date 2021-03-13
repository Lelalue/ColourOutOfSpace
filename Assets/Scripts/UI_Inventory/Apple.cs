using AlienColour.Assets.Scripts.FirstPersonCamera;
using AlienColour.Assets.Scripts.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Apple : MonoBehaviour, IInventoryItem
    {
        public IDisplay display;
        public CharacterControl control;
       

        public string Name
        {
            get
            {
                return "apple";
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
            // SoundManager.Initialize();
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }

        public void OnPickUp()
        {
           // SoundManager.PlaySound(SoundManager.Sound.apple, control.GetPosition());
            display.SetText(Name);
        }
    }
}