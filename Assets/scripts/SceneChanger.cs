using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    bool wait = false;

    public Camera a1, a2;

    public string SceneName;
    public float x;
    public int key;
    // Start is called before the first frame update
    void Start()
    {
        a2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Pause1()
    {
        Debug.Log("enumerator");
        wait = true;
        a1.gameObject.SetActive(false);
        a2.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.2f);
        Debug.Log("waited");
        wait = false;
        SceneManager.LoadScene(SceneName);
    }
    IEnumerator Pause()
    {
        wait = true;
        a1.gameObject.SetActive(false);
        a2.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.7f);
        Debug.Log("waited");
        wait = false;
        SceneManager.LoadScene(SceneName);
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "Locked" && GlobalVars.inventoryOfKeys[key] == true)
        {
            gameObject.tag = "Unlocked";
            Debug.Log("Unlocked with key" + key);
        }
        else if (gameObject.tag != "Locked")
        {
            if (SceneName.Equals("MusicRoom") || 
                SceneName.Equals("Classroom") ||
                (SceneName.Equals("Staircase") && !SceneManager.GetActiveScene().name.Equals("StairsDown"))||
                (SceneName.Equals("Library") && !SceneManager.GetActiveScene().name.Equals("RedBook")) || 
                SceneName.Equals("Bathroom")|| 
                (SceneName.Equals("HallwayStairs") && (SceneManager.GetActiveScene().name.Equals("MusicRoom") ||
                SceneManager.GetActiveScene().name.Equals("Classroom") ||
                SceneManager.GetActiveScene().name.Equals("Library") ||
                SceneManager.GetActiveScene().name.Equals("Bathroom"))))

            {
                SoundScript.PlaySound("doorOpen");
                Debug.Log("door opened");

                if (!wait)
                {
                    StartCoroutine(Pause());
                }
            }
            else if (SceneName.Equals("Rooftop") || SceneName.Equals("StairsDown"))
            {
                SoundScript.PlaySound("footsteps");
                Debug.Log("footsteps");

                if (!wait)
                {
                    StartCoroutine(Pause());
                }
            }
            else
            {
                if (!wait)
                {
                    StartCoroutine(Pause1());
                }
                //SceneManager.LoadScene(SceneName);
                Debug.Log("Clicked");
            }
            GlobalVars.cameraX = x;
        }
        else
        {
            Debug.Log("key is " + key + " and " + GlobalVars.inventoryOfKeys[key]);
            // Debug.Log("Locked");
        }

        // GameObject.Find("Main Camera").transform.position = new Vector3(x, 0, 0);
    }

}