using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundScript : MonoBehaviour
{
    public static AudioClip schoolbell, doorcreak, floorcreak, wind, footsteps;
    public static AudioClip valve, doorOpen, doorClose, bgNoise;
    public static AudioClip note1, note2, note3, note4;

    public static string[] clips = { "doorcreak", "floorcreak", "footsteps" };

    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        schoolbell = Resources.Load<AudioClip>("schoolbell");
        note1 = Resources.Load<AudioClip>("note1");
        note2 = Resources.Load<AudioClip>("note2");
        note3 = Resources.Load<AudioClip>("note3");
        note4 = Resources.Load<AudioClip>("note4");
        doorcreak = Resources.Load<AudioClip>("doorcreak");
        floorcreak = Resources.Load<AudioClip>("floorcreak");
        wind = Resources.Load<AudioClip>("wind");
        footsteps = Resources.Load<AudioClip>("footsteps");
        valve = Resources.Load<AudioClip>("valve");
        doorOpen = Resources.Load<AudioClip>("doorOpen");
        doorClose = Resources.Load<AudioClip>("doorClose");
        bgNoise = Resources.Load<AudioClip>("bgNoise");
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(string audioClip)
    {
        switch (audioClip)
        {
            case "bgNoise":
                audioSource.PlayOneShot(bgNoise);
                break;
            case "schoolbell":
                audioSource.PlayOneShot(schoolbell);
                break;
            case "note1":
                audioSource.PlayOneShot(note1);
                break;
            case "note2":
                audioSource.PlayOneShot(note2);
                break;
            case "note3":
                audioSource.PlayOneShot(note3);
                break;
            case "note4":
                audioSource.PlayOneShot(note4);
                break;
            case "doorcreak":
                audioSource.PlayOneShot(doorcreak);
                break;
            case "floorcreak":
                audioSource.PlayOneShot(floorcreak);
                break;
            case "wind":
                audioSource.PlayOneShot(wind);
                break;
            case "footsteps":
                audioSource.PlayOneShot(footsteps);
                break;
            case "valve":
                audioSource.PlayOneShot(valve);
                break;
            case "doorOpen":
                audioSource.PlayOneShot(doorOpen);
                break;
            case "doorClose":
                audioSource.PlayOneShot(doorClose);
                break;
        }
    }
}
