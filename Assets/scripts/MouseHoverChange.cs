using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverChange : MonoBehaviour
{
    [SerializeField]
    Texture2D cursorLocked;
    [SerializeField]
    Texture2D cursorUnlocked;
    public int key;
    Vector2 mousePosition;
    Vector2 center = new Vector2(16, 16);

    void Start()
    {
        mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    void OnMouseEnter()
    {
        if (!GlobalVars.keyStatus[key])
        {
            Debug.Log("hover locked");
            Cursor.SetCursor(cursorLocked, center, CursorMode.Auto);
        }
        else
        {
            Debug.Log("hover unlocked");
            Cursor.SetCursor(cursorUnlocked, center, CursorMode.Auto);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, mousePosition, CursorMode.Auto);
    }

}
