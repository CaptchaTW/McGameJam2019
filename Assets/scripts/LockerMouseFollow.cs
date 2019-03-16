using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerMouseFollow : MonoBehaviour
    
{
    float speed = 8f;
    // Start is called before the first frame update
    public Transform lockerbg;
    Vector3 posBounds;

    void Start()
    {
        posBounds = transform.position;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < Screen.width / 4 && transform.position.x < 9)
        {

            Debug.Log(transform.position.x);

            posBounds = new Vector3(posBounds.x + Time.deltaTime * speed, posBounds.y, transform.position.z);
           
        }
        else if (Input.mousePosition.x > (3 * Screen.width) / 4 && transform.position.x > -9)
        {
            Debug.Log(transform.position.x);
            //transform.position -= new Vector3(Time.deltaTime * speed, transform.position.y, transform.position.z);

            posBounds = new Vector3(posBounds.x - Time.deltaTime * speed, posBounds.y, transform.position.z);

        }
        

        transform.position = posBounds + new Vector3(Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f));
    }

}
