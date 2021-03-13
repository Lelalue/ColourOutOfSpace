using UnityEngine;
using System.Collections;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.Switcher;
using AlienColour.Assets.Scripts.FirstPersonCamera;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Drink : MonoBehaviour, IInventoryItem
    {
        public IDisplay display;
        public CharacterControl control;

        public string Name
        {
            get
            {
                return "water";
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
            //SoundManager.Initialize();
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }
        public void OnPickUp()
        {
            display.SetText(Name);

        }

        
    }
}