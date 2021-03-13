using UnityEngine;
using System.Collections;
using AlienColour.Assets.Scripts.SelectionManager;
using AlienColour.Assets.Scripts.UI_Inventory;

namespace AlienColour.Assets.Scripts.Interactables
{
    public class Looker : MonoBehaviour, ISelectionResponse
    {

        public IDisplay display;

        public void Awake()
        {
            display = transform.parent.GetComponentInChildren<IDisplay>();
        }

        public void OnDeselect(Transform selection)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelect(Transform selection)
        {
            display.SetText(selection.name);
        }

       
    }
}