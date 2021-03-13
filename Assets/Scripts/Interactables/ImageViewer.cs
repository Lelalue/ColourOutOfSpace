using AlienColour.Assets.Scripts.Interactables;
using AlienColour.Assets.Scripts.SelectionManager;
using AlienColour.Assets.Scripts.UI_Inventory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Interactables
{
    public class ImageViewer : MonoBehaviour, ISelectionResponse
    {
        public Sprite pic;
        public Sprite pic2;
        public IVCanvas ivCanvas;
        public IDisplay display;
        

        [HideInInspector] public static ImageViewer imV;

       
        public void Start()
        {
            imV = this;
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }

        public void OnSelect(Transform selection)
        {

           
        }


        public void OnDeselect(Transform selection)
        {
           // selection.GetComponent<Collider>().enabled = true;
            if (ivCanvas.gameObject.activeInHierarchy) ivCanvas.Close();

            display.SetText(pic.name);
        }
    }
}