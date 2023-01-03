
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManagerMenu : MonoBehaviour
{
    public static SoundManagerMenu instance;
    [SerializeField] AudioMixer mixer; /*Serialization is the automatic process of transforming 
    data structures or object states into a format that Unity can store and reconstruct later.*/
    [SerializeField] AudioSource eatSource;
    [SerializeField] List<AudioClip> eatClips = new List<AudioClip>(); //

    public const string MUSIC_KEY = "MusicVolume";
    public const string SFX_KEY = "SFXVolume";


    void Awake() {
        if (instance== null)
            {
                instance=this;

                DontDestroyOnLoad(gameObject);
            
            }
    
        else 
        {
            Destroy(gameObject);
        }


            LoadVolume();
    }

    public void EatSFX() {
        AudioClip clip= eatClips[Random.Range(0,eatClips.Count)];

        eatSource.PlayOneShot(clip);
    }


    void LoadVolume(){ //Volume saved in SoundSettings.cs

        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY,1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY,1f);
        mixer.SetFloat(SoundSettings.MIXER_MUSIC, Mathf.Log10(musicVolume*20));
        mixer.SetFloat(SoundSettings.MIXER_SFX, Mathf.Log10(sfxVolume*20));
    }


}
