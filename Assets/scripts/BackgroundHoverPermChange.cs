using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHoverPermChange : MonoBehaviour
{
    public GameObject originalBackground;
    public GameObject newBackGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
       originalBackground.SetActive(false);
        newBackGround.SetActive(true);

       

    }
}
