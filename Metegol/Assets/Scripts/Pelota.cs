using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared2"))
        {

            rb.velocity = new Vector3(rb.velocity.x * -1, rb.velocity.y, rb.velocity.z );

        }
        if (collision.gameObject.CompareTag("Pared"))
        {

            rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,rb.velocity.z*-1);

        }



    }


    

}
