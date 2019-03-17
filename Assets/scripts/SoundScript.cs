using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundScript : MonoBehaviour
{
    public static AudioClip schoolbell, doorcreak, floorcreak, wind, footsteps, footsteps2;
    public static AudioClip valve, unlockDoor, lockedDoor,doorOpen, doorClose, bgNoise, creepyvoice, creepylaugh, breakwindow, bookdrop;
    public static AudioClip note1, note2, note3, note4, note5, c, d, e, g, a;

    public static string[] clips = { "doorcreak", "floorcreak", "footsteps", "footsteps2", "creepyvoice", "creepylaugh", "breakwindow", "bookdrop" };

    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        schoolbell = Resources.Load<AudioClip>("schoolbell");
        note1 = Resources.Load<AudioClip>("note1");
        note2 = Resources.Load<AudioClip>("note2");
        note3 = Resources.Load<AudioClip>("note3");
        note4 = Resources.Load<AudioClip>("note4");
        note5 = Resources.Load<AudioClip>("note5");
        doorcreak = Resources.Load<AudioClip>("doorcreak");
        floorcreak = Resources.Load<AudioClip>("floorcreak");
        wind = Resources.Load<AudioClip>("wind");
        footsteps = Resources.Load<AudioClip>("footsteps");
        valve = Resources.Load<AudioClip>("valve");
        doorOpen = Resources.Load<AudioClip>("doorOpen");
        doorClose = Resources.Load<AudioClip>("doorClose");
        bgNoise = Resources.Load<AudioClip>("bgNoise");
        creepyvoice = Resources.Load<AudioClip>("creepyvoice");
        creepylaugh = Resources.Load<AudioClip>("creepylaugh");
        footsteps2 = Resources.Load<AudioClip>("footsteps2");
        breakwindow = Resources.Load<AudioClip>("breakwindow");
        bookdrop = Resources.Load<AudioClip>("bookdrop");
        lockedDoor = Resources.Load<AudioClip>("lockedDoor");
        unlockDoor = Resources.Load<AudioClip>("unlockDoor");

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
            case "note5":
                audioSource.PlayOneShot(note5);
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
            case "creepyvoice":
                audioSource.PlayOneShot(creepyvoice);
                break;
            case "creepylaugh":
                audioSource.PlayOneShot(creepylaugh);
                break;
            case "footsteps2":
                audioSource.PlayOneShot(footsteps2);
                break;
            case "breakwindow":
                audioSource.PlayOneShot(breakwindow);
                break;
            case "bookdrop":
                audioSource.PlayOneShot(bookdrop);
                break;
            case "lockedDoor":
                audioSource.PlayOneShot(lockedDoor);
                break;
            case "unlockDoor":
                audioSource.PlayOneShot(unlockDoor);
                break;
                
        }
    }
}
