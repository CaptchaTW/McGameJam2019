using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad (gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.R))
    	{
    		Debug.Log("restart game");
    		for (int x = 1; x < 5; x++) {
    			GlobalVars.inventoryOfKeys[x] = false;
    			GlobalVars.keyStatus[x] = false;
    		}
    		SceneManager.LoadScene("Main");
            Destroy(gameObject);
        }
        
    }
}
