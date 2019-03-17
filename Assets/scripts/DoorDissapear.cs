using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDissapear : MonoBehaviour
{
    [SerializeField]
    Texture2D cursorLocked;
    [SerializeField]
    Vector2 mousePosition;
    Vector2 center = new Vector2(16, 16);

    void Start()
    {
        mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    void OnMouseEnter()
    {
        Debug.Log("hover locked");
        Cursor.SetCursor(cursorLocked, center, CursorMode.Auto);
    }

    void Update()
    {
        if (GlobalVars.dissapearingDoor)
        {
            gameObject.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, mousePosition, CursorMode.Auto);
    }

}
