using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverChange : MonoBehaviour
{
    [SerializeField]
    Texture2D cursorLocked;
    [SerializeField]
    Texture2D cursorUnlocked;
    Vector2 mousePosition;

    void Start()
    {
        mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    void OnMouseEnter()
    {
        if (gameObject.tag == "Locked")
        {
            Debug.Log("hover locked");
            Cursor.SetCursor(cursorLocked, mousePosition, CursorMode.Auto);
        }
        else
        {
            Debug.Log("hover unlocked");
            Cursor.SetCursor(cursorUnlocked, mousePosition, CursorMode.Auto);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, mousePosition, CursorMode.Auto);
    }

}
