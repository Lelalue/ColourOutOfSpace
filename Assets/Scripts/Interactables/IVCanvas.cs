using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Interactables
{
    public class IVCanvas : MonoBehaviour
    {
        public Image imageHolder;



        public void Start()
        {
            gameObject.SetActive(false);
        }

        public void Activate(Sprite pic)
        {
            gameObject.SetActive(true);
            imageHolder.sprite = pic;
        }

        public void Close()
        {

            gameObject.SetActive(false);
            imageHolder.sprite = null;
        }
    }
}