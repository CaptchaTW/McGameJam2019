using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverChange : MonoBehaviour
{
    [SerializeField]
    Texture2D cursor;
    Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, mousePosition, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, mousePosition, CursorMode.Auto);
    }

}
