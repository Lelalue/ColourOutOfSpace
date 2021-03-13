using UnityEngine;
using System.Collections;
using AlienColour.Assets.Scripts.FirstPersonCamera;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Bucket : MonoBehaviour
    {
        public IDisplay display;
        public CharacterControl control;



        public string Name
        {
            get
            {
                return "bucket";
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