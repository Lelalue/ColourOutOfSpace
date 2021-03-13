using UnityEngine;
using UnityEditor;

namespace AlienColour.Assets.Scripts.SelectionManager
{
    public interface ISelectionResponse
    {
        void OnSelect(Transform selection);
        void OnDeselect(Transform selection);
    }
}