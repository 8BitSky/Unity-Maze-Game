using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject StartPos;
    [SerializeField] GameObject EndPos;
    private void OnCollisionStay(Collision other)
    {
        //Debug.Log("Wall Hit!");
        if (other.gameObject.tag == "Player")
        {
            transform.Translate(0, EndPos.transform.position.y, 0);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        //Debug.Log("Wall Hit!");
        if (other.gameObject.tag == "Player")
        {
            transform.Translate(0, StartPos.transform.position.y, 0);
        }
    }
}
