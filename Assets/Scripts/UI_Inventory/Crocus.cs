using UnityEngine;
using System.Collections;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Crocus : MonoBehaviour, IInventoryItem
    {
        public IDisplay display;
       



        public string Name
        {
            get
            {
                return "crocus";
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
            //SoundManager.PlaySound(SoundManager.Sound.key, control.GetPosition());
            display.SetText(Name);
        }
    }
}