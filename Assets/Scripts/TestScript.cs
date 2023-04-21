using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessage;
    public string updateMessage;

    public string message1;
    public string message2;
    public string message3;

    public int messagechoice;

    public string[] messages;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(startMessage);

        /*
        if (messagechoice == 1)
        {
            Debug.Log(message1);
        }

        else if (messagechoice == 2)
        {
            Debug.Log(message2);
        }

        else if (messagechoice == 3)
        {
            Debug.Log(message3);
        }

        else
        {
            Debug.Log("Invalid message choice");
        }
        */



        /* if (messagechoice == 1)
        {
            Debug.Log(messages[0]);
        }

        else if (messagechoice == 2)
        {
            Debug.Log(messages[1]);
        }

        else if (messagechoice == 3)
        {
            Debug.Log(messages[2]);
        }

        else
        {
            Debug.Log("Invalid message choice");
        } */

        // messagechoice = Random.Range(1, 4);


        /*if (messagechoice <= messages.Length && messagechoice >= 1)
            {
                Debug.Log(messagechoice - 1);
            }

            else
            {
                Debug.Log("Invalid message choice");
            }*/

        for (int i = 0; i < messages.Length; ++i)

        {
            Debug.Log(messages[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateMessage);
    }
}
