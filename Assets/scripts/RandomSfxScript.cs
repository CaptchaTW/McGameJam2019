using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSfxScript : MonoBehaviour
{ float timer=0;
    int clipIndex; 

    void Start()
    {
        StartCoroutine(PlaySound());
    }
    void Update()
    {
        timer += Time.deltaTime;
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

            timer = 0;
            Debug.Log("play bell sound");
            SoundScript.PlaySound("bellsound");
            yield return new WaitForSeconds(11f);

            for (int x = 1; x < 6; x++)
            {
                GlobalVars.inventoryOfKeys[x] = false;
                GlobalVars.keyStatus[x] = false;
            }
            if (SceneManager.GetActiveScene().name == "Classroom" || SceneManager.GetActiveScene().name == "Rooftop") { }
            else
            {
                SceneManager.LoadScene("Main");
            }
       

            StartCoroutine(PlaySound());
        }
    }
}
