using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AlienColour.Assets.Scripts.Reactors;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    internal class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse

    {
        [SerializeField] public Material active;

        [HideInInspector] public Material inactive;
        [HideInInspector] public Renderer selectionRenderer;

        

        public void OnDeselect(Transform selection)
        {
            selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = inactive;
            }
        }

        public void OnSelect(Transform selection)
        {
            inactive = selection.GetComponent<Renderer>().material;
            selectionRenderer = selection.GetComponent<Renderer>();
           
            if (selectionRenderer != null )
            {
                selectionRenderer.material = active;
            }
        }


    }
}

