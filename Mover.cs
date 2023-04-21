using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   
    [SerializeField] float speed = 10f;
    //public Rigidbody rb;

    void Start()
    {
       
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        //Debug.Log(Time.deltaTime);
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //   rb.AddForce(0, 1, 0);
        //}

    }

}
