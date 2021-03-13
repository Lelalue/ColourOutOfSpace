using UnityEngine;
using System.Collections;
using AlienColour.Assets.Scripts.SelectionManager;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public class SceneChanger3 : MonoBehaviour, ISelectionResponse
    {

        public void OnDeselect(Transform selection)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelect(Transform selection)
        {
            Debug.Log("ende");
            Loader.Load(Loader.Scene.Ende);
        }
    }
}