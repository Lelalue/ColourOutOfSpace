using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public class LoadCallback : MonoBehaviour
    {
        private bool isFirstUpdate = true;
        private void Update()
        {
            if (isFirstUpdate)
            {
                isFirstUpdate = false;
                Loader.LoaderCallback();
            }
        }
    }
}