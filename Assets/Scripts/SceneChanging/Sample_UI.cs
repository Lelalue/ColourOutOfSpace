using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public class Sample_UI : MonoBehaviour
    {

        public void Click()
        {
            Debug.Log("click zum startpanel");
            Loader.Load(Loader.Scene.StartPanel);
        }

    }
}