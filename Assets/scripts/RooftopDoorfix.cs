﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RooftopDoorfix : MonoBehaviour
{
    public GameObject door;
    private SpriteRenderer SpriteR;
    // Start is called before the first frame update
    void Start()
    {
        SpriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.inventoryOfKeys[2])
        {
            GlobalVars.keyStatus[2] = true;
            SpriteR.enabled = false;
        }
    }
}
