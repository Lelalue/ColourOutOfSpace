using UnityEngine;
using System.Collections;
using System.Reflection;


namespace AlienColour.Assets.Scripts.Sound
{
    public class GameAssets : MonoBehaviour
    {


        private static GameAssets _i;

        public static GameAssets i
        {
            get
            {
                if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
                return _i;
            }
        }

        public SoundAudioClip[] clipArray;
        public void Awake()
        {
            //DontDestroyOnLoad(this.gameObject);
        }

        [System.Serializable]
        public class SoundAudioClip
        {
            public SoundManager.Sound sound;

            public AudioClip audioClip;

            public int priority;

            public int volume;
        }
    }
}