using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource sfx;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void PlayBGM(AudioClip clip)
    {
        bgm.clip = clip;
        bgm.Play();
    }

    public void StopBGM()
    {
        if (bgm.isPlaying == false)
            return;
        
        bgm.Stop();
    }

    public void PauseBGM()
    {
        if (bgm.isPlaying == false)
            return;

        bgm.Pause();
    }

    public void SetBGM(float volume, float pitch)
    {
        bgm.volume = volume;
        bgm.pitch = pitch;
    }

    public void PlaySFX(AudioClip clip)
    {
        //동시에 여러 음원을 재생할 수 있음
        sfx.PlayOneShot(clip);

        //동시에 여러 음원을 재생하지 못함
        //sfx.clip = clip;
        //sfx.Play();
    }

    public void SetSFX(float volume, float pitch = 1f)
    {
        sfx.volume = volume;
        sfx.pitch = pitch;
    }


}
