using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMirror : MonoBehaviour
{

    public Sprite ogSprite;
    public Sprite newSprite;
    public Sprite newSprite2;
    private SpriteRenderer sr;
    private float timer;
    private int blinktime = 0;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        

        if (timer > 1 && blinktime == 0) // change after 3 seconds
        {
            if (Random.value > 0.993)
            {
                sr.sprite = newSprite;
                timer = 0;
                blinktime = 1;
            }
        }

        if (timer > 0.05 && blinktime == 1) 
        {

            sr.sprite = newSprite2;
            timer = 0;
            blinktime = 2;
        }

        if (timer > 0.05 && blinktime == 2) 
        {

            sr.sprite = newSprite;
            timer = 0;
            blinktime = 3;
        }
        if (timer > 0.05 && blinktime == 3) 
        {

            sr.sprite = ogSprite;
            timer = 0;
            blinktime = 0;
        }

    }
}
