using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCrack : MonoBehaviour
{

    public Sprite ogSprite;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite newSprite3;
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


        if (timer > 3 && frame == 0)
        {

            sr.sprite = newSprite;
            timer = 0;
            frame = 1;
        }

        if (timer > 0.1 && frame == 1)
        {

            sr.sprite = newSprite2;
            timer = 0;
            frame = 2;
        }

        if (timer > 0.1 && frame == 2)
        {

            sr.sprite = newSprite3;
            timer = 0;
            frame = 3;
        }


    }
}
