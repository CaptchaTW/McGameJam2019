using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClick: MonoBehaviour
{
    [SerializeField]
    Vector2 mousePosition;
    public int keyNumber;
    // public GameObject Key;
    // public int keyAnimation = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVars.inventoryOfKeys[keyNumber] == true){
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void OnMouseDown()
    {   
        GlobalVars.inventoryOfKeys[keyNumber] = true ;
        Cursor.SetCursor(null, mousePosition, CursorMode.Auto);
        gameObject.SetActive(false);
        Debug.Log("key " + keyNumber + " got");
        // if (keyAnimation == 1) {
        //     KeyImage.enabled = true;
        // }
    }

}
