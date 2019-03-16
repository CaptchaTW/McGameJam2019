using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [SerializeField] public static AudioClip schoolbell;
    [SerializeField] public static AudioClip note1, note2, note3, note4;

    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        schoolbell = Resources.Load<AudioClip>("schoolbell");
        note1 = Resources.Load<AudioClip>("note1");
        note2 = Resources.Load<AudioClip>("note2");
        note3 = Resources.Load<AudioClip>("note3");
        note4 = Resources.Load<AudioClip>("note4");
    }

    public static void playSound(string audioClip)
    {
        switch (audioClip)
        {
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

        }
    }
}
