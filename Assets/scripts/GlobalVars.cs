using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class GlobalVars
{

	public static float cameraX;
 
    public static bool[] inventoryOfKeys = {true, false, false, false, false};
    public static bool[] keyStatus = {true, false, false, false, false};
    public static float currentCameraX = 0;

  //   void Start(){
  //   	for (int x = 0; x < 5; x++){
  //   	keyStatus[x] = false;
	 //    }
	 //    for (int x = 0; x < 5; x++){
	 //    	inventoryOfKeys[x] = false;
	 //    }
	 //    inventoryOfKeys[0] = true;
		// keyStatus[0] = true;
  //   }
    
    
 
}


// key 1 = musicroom key (in shoe)
// key 2 = bathroom (in piano)
// key 3 = library key (little pot in classroom)
// key 4 = basement (valve in bathroom)