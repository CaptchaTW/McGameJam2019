using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SequenceFollowCheck : MonoBehaviour
{
 public  static int CountMax = 4;
    // public int keyNumber;
    public static Queue<int> correctPattern = new Queue<int>();
   public static Queue<int> playerSequence = new Queue<int>();


    // Start is called before the first frame update
    void Start()
    {
        correctPattern.Enqueue(1);
        correctPattern.Enqueue(2);
        correctPattern.Enqueue(3);
        correctPattern.Enqueue(4);
        playerSequence.Enqueue(0);
        playerSequence.Enqueue(0);
        playerSequence.Enqueue(0);
        playerSequence.Enqueue(0);
    }

    // Update is called once per frame
    void Update()
    {
        //CheckSequence();
        
        

    }



    public static bool CheckSequence()
    {
        if (!GlobalVars.inventoryOfKeys[2])
        {
            if (playerSequence.ToArray()[0] == correctPattern.ToArray()[0] && playerSequence.ToArray()[1] == correctPattern.ToArray()[1] &&playerSequence.ToArray()[2] == correctPattern.ToArray()[2] && playerSequence.ToArray()[3] == correctPattern.ToArray()[3])
            {
                GlobalVars.inventoryOfKeys[2] = true;
                GlobalVars.keyStatus[2] = true;
                Debug.Log("Key 2 got");
                return true;
            }
            return false;
        }
        return false;
    }

}
