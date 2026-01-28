using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    AudioClip CooSound;
    
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.GotPoint += HandlePoints;
    }

    public void HandlePoints()
    {
        m_MyAudioSource.PlayOneShot(CooSound);
    }
}
