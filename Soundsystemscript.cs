using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Soundsystemscript : MonoBehaviour
{
    [SerializeField] private AudioSource MusicSource;
    [SerializeField] private AudioSource SFXsource; 

    public AudioClip background;
    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = background;
        MusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
