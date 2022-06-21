using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;  
    private Vector3 mouseReleasePos;

    private Rigidbody rb;
    private bool isShoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }


    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        
        Shoot(mousePressDownPos-mouseReleasePos);
    }

    
    // Update is called once per frame
    void Shoot(Vector3 Force)
    {
        float forceMultiplier = mousePressDownPos.y-mouseReleasePos.y;
        if(isShoot)
        {
            return;
        }
        Debug.Log("force: "+forceMultiplier);
        if (forceMultiplier > 1000)
            forceMultiplier = 1000;

        if (forceMultiplier < 100)
            forceMultiplier = 100;
        var dir = Camera.main.transform.forward; 

        rb.AddForce(dir* forceMultiplier);
//        rb.AddForce(new Vector3(0,0,Force.x)*forceMultiplier);
        //isShoot=true;
    }
}