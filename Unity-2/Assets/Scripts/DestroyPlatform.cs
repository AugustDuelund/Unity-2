using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    void FixedUpdate()
    {
        RaycastHit hit;
        //Registers when players feet hits the platform.
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.transform.tag == "Platform") //transform = the given object, tag = tag of the object. In this case platform.
            {
                var rigid = hit.transform.GetComponent <Rigidbody>(); //Fetches the rigidbody of object hit.
                rigid.useGravity = true; //Changes the value of gravity on the rigidbody to true, so object falls.
            }
        }
    }
}
