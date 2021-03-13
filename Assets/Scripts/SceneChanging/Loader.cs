using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlienColour.Assets.Scripts.SceneChanging
{
    public static class Loader
    {
        public static string prevScene;
        public enum Scene
        {
            StartPanel,
            LoadingScene,
            SampleScene,
            Bunt,
            Grau,
            Ende
           
        }

        private static Action onLoaderCallback;
        public static void Load(Scene scene)
        {
            onLoaderCallback = () =>
             {
                 SceneManager.LoadScene(scene.ToString());
             };
            
            SceneManager.LoadScene(Scene.LoadingScene.ToString());
            prevScene = Scene.LoadingScene.ToString();
        }

        public static void LoaderCallback()
        {
            if(onLoaderCallback != null)
            {
                onLoaderCallback();
                onLoaderCallback = null;
            }
        }
    }
}