using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lava : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("LavaLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}