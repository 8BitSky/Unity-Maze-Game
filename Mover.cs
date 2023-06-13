using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   
    [SerializeField] float speed = 10f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        //Debug.Log(Time.deltaTime);
        //float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //transform.Translate(xValue, 0, zValue);
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * speed);
        }


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
