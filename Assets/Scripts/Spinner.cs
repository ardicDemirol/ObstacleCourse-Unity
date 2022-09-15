using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle,yAngle,zAngle ;

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
