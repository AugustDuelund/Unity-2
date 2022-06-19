using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        GameObject.Find("Canvas").SendMessage("Finish");
    }
}
