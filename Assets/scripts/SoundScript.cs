using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [SerializeField] public static AudioClip sound1, sound2, sound3, sound4, sound5;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        sound1 = Resources.Load<AudioClip>("sound1");
        sound2 = Resources.Load<AudioClip>("sound2");
        sound3 = Resources.Load<AudioClip>("sound3");
        sound4 = Resources.Load<AudioClip>("sound4");
        sound5 = Resources.Load<AudioClip>("sound5");
    }

    public static void playSound(string audioClip)
    {
        switch (audioClip)
        {
            case "sound1":
                audioSource.PlayOneShot(sound1);
                break;
            case "sound2":
                audioSource.PlayOneShot(sound2);
                break;
            case "sound3":
                audioSource.PlayOneShot(sound3);
                break;
            case "sound4":
                audioSource.PlayOneShot(sound4);
                break;

        }
    }
}
