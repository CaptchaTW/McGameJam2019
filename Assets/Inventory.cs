using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory InventoryKeys;
    public bool[] inventoryOfKeys = new bool[5];
    void Awake()
    {
        if (InventoryKeys != null)
            GameObject.Destroy(InventoryKeys);
        else
            InventoryKeys = this;

        DontDestroyOnLoad(this);
    }
}
