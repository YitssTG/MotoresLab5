using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicaFondo;
    public AudioSource sfxSource;
    public static AudioManager instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
        if (musicaFondo == null)
            musicaFondo = GetComponent<AudioSource>(); 
    }
    public void SetVolumenMusica(float volumen)
    {
        if (musicaFondo != null)
            musicaFondo.volume = volumen;
    }
    public void SetVolumenSFX(float volumen)
    {
        if (sfxSource != null)
            sfxSource.volume = volumen;
    }
    public void ReproducirSFX(AudioClip clip)
    {
        if (sfxSource != null && clip != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
}
