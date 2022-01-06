using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropperScript : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRend;
    Rigidbody rigidBody;
    void Start()
    {
       
        meshRend = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Time.time > 3){
            meshRend.enabled = true;
            rigidBody.useGravity = true;
            
        }
    }
}
