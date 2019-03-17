using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceClick : MonoBehaviour
{
    public int SequenceNumber;
   float timer = 0;
   bool playSound;
   bool playedSound;


    // Start is called before the first frame update
    void Start()
    {
        playSound= false;
        playedSound = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playSound && !playedSound){
            timer += Time.deltaTime;
            if (timer > 1.5){
                SoundScript.PlaySound("doorUnlock");
                playedSound = true;
            }
        }
    }

    void OnMouseDown()
    {
        //Debug.Log("clicked");

        

        if (SequenceFollowCheck.playerSequence.Count == SequenceFollowCheck.CountMax)
        {

            SequenceFollowCheck.playerSequence.Dequeue();
            SequenceFollowCheck.playerSequence.Enqueue(SequenceNumber);
            PlayPiano(SequenceNumber);
        }
        else
        {
            SequenceFollowCheck.playerSequence.Enqueue(SequenceNumber);
            PlayPiano(SequenceNumber);

            for (int i = 0; i < 4; i++)
            {
                Debug.Log(SequenceFollowCheck.playerSequence.ToArray()[i]);
            }
            //  }
        }

        if(SequenceFollowCheck.CheckSequence()){
            playSound = true;
        }
    }

    public static void PlayPiano(int SequenceNumber)
    {
        switch (SequenceNumber)
        {
            case 1:
                SoundScript.PlaySound("note1");
                Debug.Log("played note 1");
                break;
            case 2:
                SoundScript.PlaySound("note2");
                Debug.Log("played note 2");
                break;
            case 3:
                SoundScript.PlaySound("note3");
                Debug.Log("played note 3");
                break;
            case 4:
                SoundScript.PlaySound("note4");
                Debug.Log("played note 4");
                break;
             case 5:
                SoundScript.PlaySound("note5");
                Debug.Log("played note 5");
                break;
            default:
                break;
        }
    }
}
