using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceClick : MonoBehaviour
{
    public int SequenceNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Debug.Log("clicked");

        if (SequenceFollowCheck.playerSequence.Count == SequenceFollowCheck.CountMax)
        {

            SequenceFollowCheck.playerSequence.Dequeue();
            SequenceFollowCheck.playerSequence.Enqueue(SequenceNumber);
        }
        else
        {
            SequenceFollowCheck.playerSequence.Enqueue(SequenceNumber);

            for (int i = 0; i < 4; i++)
            {
                Debug.Log(SequenceFollowCheck.playerSequence.ToArray()[i]);
            }
            //  }
        }
    }
}
