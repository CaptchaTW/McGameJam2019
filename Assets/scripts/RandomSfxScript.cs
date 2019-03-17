using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSfxScript : MonoBehaviour
{
    int clipIndex; 

    void Start()
    {
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound()
    {
        if (SceneManager.GetActiveScene().name.Equals("Main") ||
            SceneManager.GetActiveScene().name.Equals("Schoolyard"))
        {
            Debug.Log("no sound");
            yield return new WaitForSeconds(5f);
            StartCoroutine(PlaySound());
        }
        else
        {
            yield return new WaitForSeconds(Random.Range(10f, 20f));

            clipIndex = Random.Range(0, SoundScript.clips.Length - 1);

            Debug.Log("play random sound");
            SoundScript.PlaySound(SoundScript.clips[clipIndex]);

            yield return new WaitForSeconds(Random.Range(15f, 20f));

            Debug.Log("play schoolbell sound");
            SoundScript.PlaySound("schoolbell");
            StartCoroutine(PlaySound());
        }
        
        
    }
}
