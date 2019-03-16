using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    
    public string SceneName;
    public float x;
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
        SceneManager.LoadScene(SceneName);
        Debug.Log("Clicked");
        GlobalVars.cameraX = x;
        // GameObject.Find("Main Camera").transform.position = new Vector3(x, 0, 0);
    }
}
