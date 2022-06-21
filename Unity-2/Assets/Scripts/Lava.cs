using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lava : MonoBehaviour
{
    // Start is called before the first frame update
    //Platform is set to have a collider with "On trigger" checked, object needs rigidbody for this to work. 
    //Loads next scene/level.
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("LavaLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
