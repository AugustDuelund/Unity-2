using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatformRandom : MonoBehaviour
{

    public Object platformA;
    public Object platformB;

      void Start()
    {
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.transform.tag == "Platform")
            {
                var rigid = hit.transform.GetComponent <Rigidbody>();
                rigid.useGravity = true;
            }
        }
    }
}
