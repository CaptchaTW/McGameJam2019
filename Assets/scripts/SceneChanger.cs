using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string SceneName;
    public float x;
    public int key;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "Locked" && GlobalVars.inventoryOfKeys[key] == true){
            gameObject.tag = "Unlocked";
            Debug.Log("Unlocked with key" + key);
        }
        else if (gameObject.tag != "Locked"){
            SceneManager.LoadScene(SceneName);
            Debug.Log("Clicked");
            GlobalVars.cameraX = x;
        }
        else {
            Debug.Log("key is " + key + " and " + GlobalVars.inventoryOfKeys[key]);
            // Debug.Log("Locked");
        }

        // GameObject.Find("Main Camera").transform.position = new Vector3(x, 0, 0);
    }
}
