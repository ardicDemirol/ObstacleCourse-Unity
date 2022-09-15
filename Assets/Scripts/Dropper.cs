using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rendererr;
    Rigidbody rigidBody;
    [SerializeField] float waitTime = 3f;


    void Start()
    {
        rendererr = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rendererr.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > waitTime)
        {
            rendererr.enabled = true;
            rigidBody.useGravity=true;  
        }
    }
}
