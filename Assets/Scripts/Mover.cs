using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xvalue, 0f, zvalue);
    }
}
