using UnityEngine;
using System.Collections;
public class SceneImage : MonoBehaviour
{
    public Texture atexture;

    // Start is called before the first frame update
    void Start()
    {
 

}

    // Update is called once per frame
    void Update()
    {
        
    }
    void onGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, 10, 10), atexture);
    }
}
