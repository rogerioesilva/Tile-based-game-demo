using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtracks : MonoBehaviour
{
    public List<AudioClip> Sources;

    public void PlayTrack(int number)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = Sources[number];
        GetComponent<AudioSource>().Play();
    }
}
