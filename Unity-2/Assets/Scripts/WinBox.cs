using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    //Is run when landing on last platform in squidlevel and finishing game. Sends finish to the timer script on canvas.
    void OnTriggerEnter (Collider other)
    {
        GameObject.Find("Canvas").SendMessage("Finish");
    }
}
