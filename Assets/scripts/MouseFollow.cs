﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
    
{
    public float speed = 8f;
    public float leftBound;
    public float rightBound;
    Vector3 posBounds;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(GlobalVars.cameraX, 0, -10);
        posBounds = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < Screen.width / 4 && transform.position.x > leftBound)
        {

            Debug.Log(transform.position.x);

            posBounds = new Vector3(posBounds.x - Time.deltaTime * speed, posBounds.y, transform.position.z);
           
        }
        else if (Input.mousePosition.x > (3 * Screen.width) / 4 && transform.position.x < rightBound)
        {
            Debug.Log(transform.position.x);
            //transform.position -= new Vector3(Time.deltaTime * speed, transform.position.y, transform.position.z);

            posBounds = new Vector3(posBounds.x + Time.deltaTime * speed, posBounds.y, transform.position.z);

        }
        

        transform.position = posBounds + new Vector3(Random.Range(-0.005f, 0.005f), Random.Range(-0.005f, 0.005f), Random.Range(-0.02f, 0.02f));
    }

}
