using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("FinishLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
