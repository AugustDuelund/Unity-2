using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
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
