using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource m_MyAudioSource;
    [SerializeField] AudioClip CooSound;
    [SerializeField] AudioClip DeathSound;
    [SerializeField] AudioClip FlapEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.GotPoint += HandlePoints;
        Locator.Instance.Player.Died += Death;
        Locator.Instance.Player.Flapped += FlapSound;
    }

    public void HandlePoints()
    {
        Debug.Log("Playsound");
        m_MyAudioSource.PlayOneShot(CooSound);
    }

    void Death()
    {
        m_MyAudioSource.PlayOneShot(DeathSound);
    }

    void FlapSound()
    {
        m_MyAudioSource.PlayOneShot(FlapEffect);
    }
}
