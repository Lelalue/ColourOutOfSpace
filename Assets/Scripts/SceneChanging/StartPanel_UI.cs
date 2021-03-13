
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public class StartPanel_UI : MonoBehaviour
    {
        public void Click()
        {
            
                Debug.Log("Click zum game");
                Loader.Load(Loader.Scene.SampleScene);
     
        }


        public void Quit()
        {
            Application.Quit();
        }
    }
}