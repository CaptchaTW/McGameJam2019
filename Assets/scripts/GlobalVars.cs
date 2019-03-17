using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class GlobalVars
{

	public static float cameraX;
 
    public static bool[] inventoryOfKeys = {true, false, false, false, false, false};
    public static bool[] keyStatus = {true, false, false, false, false, false};
    public static float currentCameraX = 0;
    public static bool dissapearingDoor = false;

}


// key 1 = musicroom key (in shoe)
// key 2 = rooftop (in piano)
// key 3 = library key (cupboard in classroom)
// key 4 = basement (valve in bathroom)
// key 5 = bathroom (rooftop)