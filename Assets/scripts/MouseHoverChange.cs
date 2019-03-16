using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverChange : MonoBehaviour
{
    [SerializeField]
    Texture2D cursor;


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

}
