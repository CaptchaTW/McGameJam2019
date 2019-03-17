using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RooftopAnimation : MonoBehaviour
{

    public Sprite ogSprite;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public Sprite newSprite5;
    private SpriteRenderer sr;
    private float timer;
    private int frame = 0;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (GlobalVars.currentCameraX < 5 && frame == 0)
        {
            frame = 1;
        }

        if (GlobalVars.currentCameraX > 41 && frame == 1)
        {
            sr.sprite = newSprite;
            frame = 2;
        }

        if (GlobalVars.currentCameraX < 5 && frame == 2)
        {
            sr.sprite = newSprite2;
            GlobalVars.dissapearingDoor = true;
            frame = 3;
        }

        if (GlobalVars.currentCameraX > 41 && frame == 3)
        {
            sr.sprite = newSprite3;
            frame = 4;
        }

        if (GlobalVars.currentCameraX < 5 && frame == 4)
        {
            sr.sprite = newSprite4;
            frame = 5;
        }

        if (GlobalVars.currentCameraX < 41 && frame == 5)
        {
            timer = 0;
            frame = 6;
        }

        if (timer > 5 && frame == 6)
        {
            timer = 0;
            sr.sprite = newSprite5;
            frame = 7;
        }

        if (timer > 2 && frame == 7)
        {

            GlobalVars.inventoryOfKeys[5] = true;
            GlobalVars.keyStatus[5] = true;
            SceneManager.LoadScene("Bathroom");
        }


    }
}
