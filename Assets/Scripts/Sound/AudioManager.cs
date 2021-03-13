using UnityEngine;
using System.Collections;

namespace AlienColour.Assets.Scripts.Sound
{
    public class AudioManager : MonoBehaviour
    {
        private AudioSource musicSource;
        private AudioSource musicSource2;
        private AudioSource sfxSource;

        private bool firstMusicSourceIsPlaying;
        private bool firstMusicSourceIsActive;

        private static AudioManager instance;
        public static AudioManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = FindObjectOfType<AudioManager>();
                    if(instance == null)
                    {
                        instance = new GameObject("Spawned AudioManager", typeof(AudioManager)).GetComponent<AudioManager>();
                    }
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);

            musicSource = this.gameObject.AddComponent<AudioSource>();
            musicSource2 = this.gameObject.AddComponent<AudioSource>();
            sfxSource = this.gameObject.AddComponent<AudioSource>();

            musicSource.loop = true;
            musicSource2.loop = true;
        }

        public void PlayMusic(AudioClip musicClip)
        {
            AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;

            activeSource.clip = musicClip;
            activeSource.volume = 1;
            activeSource.Play();
        }

        public void StopMusic( AudioClip musicClip)
        {
            AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;

            activeSource.clip = musicClip;
            
            activeSource.Stop();

        }

        public void PlayMusicWithFade(AudioClip newClip, float transitionTime = 1.0f)
        {
            AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;
            StartCoroutine(UpdateMusicWithFade(activeSource, newClip, transitionTime));
        }

        public void PlayMusicWithCrossFade(AudioClip musicClip, float transitionTime = 1.0f)
        {
            AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2;
            AudioSource newSource = (firstMusicSourceIsActive) ? musicSource2 : musicSource;

            firstMusicSourceIsActive = !firstMusicSourceIsActive;

            newSource.clip = musicClip;
            newSource.Play();
            StartCoroutine(UpdateMusicWithCrossFade(activeSource, newSource, transitionTime));

        }

        private IEnumerator UpdateMusicWithFade (AudioSource activeSource, AudioClip newClip, float transitionTime )
        {
            if (!activeSource.isPlaying)
            {
                activeSource.Play();
            }
            float t = 0.0f;

            //fade out
            for(t = 0; t< transitionTime; t+=Time.deltaTime)
            {
                activeSource.volume = (1 - (t / transitionTime));
                yield return null;
            }

            activeSource.Stop();
            activeSource.clip = newClip;
            activeSource.Play();

            //fade in
            for (t = 0; t < transitionTime; t += Time.deltaTime)
            {
                activeSource.volume = (t / transitionTime);
                yield return null;
            }
        }

        private IEnumerator UpdateMusicWithCrossFade(AudioSource original, AudioSource newSource, float transitionTime)
        {
            float t = 0.0f;
            for(t= 0.0f; t<transitionTime; t+= Time.deltaTime)
            {
                original.volume = 1 - (t / transitionTime);
                newSource.volume = (t / transitionTime);
                yield return null;
            }

            original.Stop();
        }

        public void PlaySfx(AudioClip clip)
        {
            sfxSource.PlayOneShot(clip);
        }

        public void PlaySfx(AudioClip clip, float volume)
        {
            sfxSource.PlayOneShot(clip, volume);
        }

        public void SetMusicVolume ( float volume)
        {
            musicSource.volume = volume;
            musicSource2.volume = volume;

        }

        public void SetSfxVolume(float volume)
        {
            sfxSource.volume = volume;
        }

    }
}