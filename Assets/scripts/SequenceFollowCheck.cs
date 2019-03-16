using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceFollowCheck : MonoBehaviour
{
 public  static int CountMax = 4;
   public static Queue<int> correctPattern = new Queue<int>();
   public static Queue<int> playerSequence = new Queue<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CheckSequence());
    }
    bool CheckSequence()
    {
        if (correctPattern.ToArray().Equals(playerSequence.ToArray()))
        {
            return true;
        }
        else return false;
    }

}
