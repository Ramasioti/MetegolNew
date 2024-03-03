using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float speed = 0.5f;

    public float torque = 1f;

    public Animator animator;

    private Rigidbody rb;

    public int equipo; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();    
        rb.maxAngularVelocity = 200;
    }

    
    
    public void movimiento(int value)
    {

        rb.AddForce(Vector3.forward*speed*value,ForceMode.Force);
       
    }


    public void patear()
    {
        animator.SetTrigger("patear"); 
       
    }


    public void Soltar()
    {
        rb.AddTorque(0, 0, torque * equipo, ForceMode.Force);
    }

}
