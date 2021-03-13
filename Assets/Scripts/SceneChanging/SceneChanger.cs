using AlienColour.Assets.Scripts.SelectionManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public class SceneChanger : MonoBehaviour, ISelectionResponse

    {
        public void OnDeselect(Transform selection)
        {
            throw new System.NotImplementedException();
        }

        public void OnSelect(Transform selection)
        {
            Debug.Log("click zur bunten szene");
            Loader.Load(Loader.Scene.Bunt);
        }

        
    }
}