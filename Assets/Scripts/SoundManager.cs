using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip CollectcoinSound, DashSound, DeathSound, HookSound, JumpSound, CheckpointSound, OpenChestSound, BounceSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        CollectcoinSound = Resources.Load<AudioClip>("coinCollectSound");
        DashSound = Resources.Load<AudioClip>("dashSound");
        DeathSound = Resources.Load<AudioClip>("deathSound");
        HookSound = Resources.Load<AudioClip>("hookSound");
        JumpSound = Resources.Load<AudioClip>("jumpSound");
        CheckpointSound = Resources.Load<AudioClip>("checkpointSound");
        OpenChestSound = Resources.Load<AudioClip>("openChestSound");
        BounceSound = Resources.Load<AudioClip>("bounceSound");


        audioSrc = GetComponent<AudioSource>();
        audioSrc.playOnAwake = false;
        
    }
    public static void PlaySound(string clip){
        switch (clip){
            case "CollectCoinSound":
                audioSrc.PlayOneShot(CollectcoinSound);
            break;
            case "DashSound":
                audioSrc.PlayOneShot(DashSound);
            break;
            case "DeathSound":
                audioSrc.PlayOneShot(DeathSound);
            break;
            case "HookSound":
                audioSrc.PlayOneShot(HookSound);
            break;
            case "JumpSound":
                audioSrc.PlayOneShot(JumpSound);
            break;
            case "CheckpointSound":
                audioSrc.PlayOneShot(CheckpointSound);
            break;
            case "OpenChestSound":
                audioSrc.PlayOneShot(OpenChestSound);
            break;
            case "BounceSound":
            audioSrc.PlayOneShot(BounceSound);
            break;
        }
    }
}
