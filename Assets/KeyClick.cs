using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClick: MonoBehaviour
{
    GameObject Player;
    public GameObject Key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void OnMouseDown()
    {
        Player = GameObject.Find("Player");
        Inventory.InventoryKeys.inventoryOfKeys[0] = true ;
        Key.gameObject.SetActive(false);

    }

}
