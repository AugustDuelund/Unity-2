using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicLava : MonoBehaviour
{
    public static MusicLava instance;
    
    //Awake is run when object is instantiated
    //Singleton that prevents music from being stopped/restarted when loading same level also prevents duplicates of the object.
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    //If statement to destroy object when leaving scene/level.
    void Update()
    {
        if(SceneManager.GetActiveScene().name != "LavaLevel")
        {
            Destroy(gameObject);
        }
        
    }
}
