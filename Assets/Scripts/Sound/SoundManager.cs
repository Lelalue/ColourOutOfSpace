using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienColour.Assets.Scripts.Sound
{
    public static class SoundManager
    {

        public enum Sound
        {
            background1,
            background2,
            background3,
            door,
            book,
            pickup, 
            water,
            drink,
            walk,
            applebite,
            apple,
            pear,
            key1,
            letter,
            letterpickup,
            diary,
            diarypickup,
            cup,
            bucket,
            crocus,
            tulip,           
            cemetery,
            well,
            flower,
            szene1,
            ausblick,
            szene2,
            apple2,
            water2,
            key2,
            tulip2,
            crocus2,
            pear2,
            cemetery2,
            well2,
            trees,
            cup2,
            bucket2,
            flower2,
            letter2,
            letterpickup2,
            diary2,
            diarypickup2,
            szene3,
            apple3,
            water3,
            key3,
            tulip3,
            crocus3,
            cup3,
            bucket3,
            pear3,
            cemetery3,
            well3,
            flower3,
            letter3,
            letterpickup3,
            diary3,
            diarypickup3,
            grey,
            last





        }

        private static Dictionary<Sound, float> soundTimerDictionary;
        private static GameObject oneShotGO;
        private static AudioSource oneSource;
        private static GameObject soundGameObject;


        

        public static void Initialize()
        {
            soundTimerDictionary = new Dictionary<Sound, float>();
            soundTimerDictionary[Sound.walk] = 0f;
        }

        public static void PlaySound(Sound sound, Vector3 position)
        {
            if (CanPlay(sound))
            {
                GameObject soundGameObject = new GameObject("Sound");
                soundGameObject.transform.position = position;
                AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
                audioSource.clip = GetAudioClip(sound);
                audioSource.maxDistance = 100f;
                audioSource.spatialBlend = 1f;
                audioSource.rolloffMode = AudioRolloffMode.Linear;
                audioSource.dopplerLevel = 0f;

                audioSource.volume = GetVolume(sound);
                audioSource.priority = GetPriority(sound);

                audioSource.Play();

                

                Object.Destroy(soundGameObject, audioSource.clip.length);
            }
        }

        public static void PlaySound(Sound sound)
        {
            if (CanPlay(sound))
            {
                if (oneShotGO == null)
                {
                    oneShotGO = new GameObject("One Shot Sound");
                    oneSource = oneShotGO.AddComponent<AudioSource>();
                }
                    oneSource.PlayOneShot(GetAudioClip(sound));
                
            }
         }

        [System.Obsolete]
        public static void Stop(Sound sound)
        {
            if (!soundGameObject.active)
            {
                AudioSource audioSource = soundGameObject.GetComponent<AudioSource>();
                audioSource.clip = GetAudioClip(sound);
                audioSource.Stop();
            }
        }

        private static bool CanPlay(Sound sound)
        {
            switch (sound)
            {
                default:
                    return true;
                case Sound.walk:
                    if (soundTimerDictionary.ContainsKey(sound))
                    {
                        float lastTimePlayed = soundTimerDictionary[sound];
                        float playerMoveTimeMax = 40f;
                        if (lastTimePlayed + playerMoveTimeMax < Time.time)
                        {
                            soundTimerDictionary[sound] = Time.time;
                            return true;
                        }
                        else return false;
                    }
                    else return true;
                   // break;
                
            }
        }

        private static AudioClip GetAudioClip(Sound sound)
        {
            foreach(GameAssets.SoundAudioClip soundAudio in GameAssets.i.clipArray)
            {
                if( soundAudio.sound == sound)
                {
                    return soundAudio.audioClip;
                }
            }
            Debug.LogError("error sound");
            return null;
        }

        private static int GetPriority(Sound sound)
        {
            foreach (GameAssets.SoundAudioClip soundAudio in GameAssets.i.clipArray)
            {
                if (soundAudio.sound == sound)
                {
                    return soundAudio.priority;
                }
            }
            Debug.LogError("error sound");
            return 0;
        }

        private static int GetVolume(Sound sound)
        {
            foreach (GameAssets.SoundAudioClip soundAudio in GameAssets.i.clipArray)
            {
                if (soundAudio.sound == sound)
                {
                    return soundAudio.volume;
                }
            }
            Debug.LogError("error sound");
            return 0;
        }
    }
}