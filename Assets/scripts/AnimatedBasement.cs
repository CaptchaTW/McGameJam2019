using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedBasement : MonoBehaviour
{

    public Sprite ogSprite;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
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
 

        if (timer > 0.05 && frame == 0) 
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite;
                timer = 0;
                frame = 1;
            }
        }

        if (timer > 0.05 && frame == 1)
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite2;
                timer = 0;
                frame = 2;
            }
        }

        if (timer > 0.05 && frame == 2)
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite3;
                timer = 0;
                frame = 3;
            }
        }
        if (timer > 0.05 && frame == 3)
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite4  ;
                timer = 0;
                frame = 4;
            }
        }
        if (timer > 0.05 && frame == 4)
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite3;
                timer = 0;
                frame = 5;
            }
        }

        if (timer > 0.05 && frame == 5)
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite2;
                timer = 0;
                frame = 6;
            }
        }

        if (timer > 0.05 && frame == 6) 
        {
            if (Random.value > 0.950)
            {
                sr.sprite = newSprite;
                timer = 0;
                frame = 7;
            }
        }
        if (timer > 0.05 && frame == 7)
        {

            if (Random.value > 0.950)
            {
                sr.sprite = ogSprite;
                timer = 0;
                frame = 0;
            }
        }

    }
}
