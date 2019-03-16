using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
    
{
    float speed = 8f;
    // Start is called before the first frame update
    public Transform lockerbg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < Screen.width / 4)
        {
            
            transform.position += new Vector3(Time.deltaTime * speed, transform.position.y, transform.position.z);
        }
        else if (Input.mousePosition.x > (3*Screen.width) / 4) 
        {
            transform.position -= new Vector3(Time.deltaTime * speed, transform.position.y, transform.position.z);
        }
    }
}
