using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySoundScript : MonoBehaviour
{

    private void Awake()
    {
        GameObject[] sounds = GameObject.FindGameObjectsWithTag("Sound");
        if (sounds.Length > 1) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
