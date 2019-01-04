using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{

    public Slider Volume;
    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.Play();
    }

    void Update()
    {
        MusicSource.volume = Volume.value;
    }
}
