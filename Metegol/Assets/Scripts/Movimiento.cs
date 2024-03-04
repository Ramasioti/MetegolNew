using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float speed = 0.5f;

    public float torque = 1f;

    public Animator animator;

    private Rigidbody rb;

    public int equipo; 

    bool left, right = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();    
        rb.maxAngularVelocity = 200;
    }

    
    
    public void movimiento(int value)
    {
       
        transform.Translate(Vector3.forward * speed * value * Time.deltaTime);
        //rb.AddForce(Vector3.forward*speed*value,ForceMode.Force);
       
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.Clamp(transform.localPosition.z, equipo == 0 ? -0.962f:-0.05f, equipo == 0 ? -0.804f:0.106f));
    }


    public void patear()
    {
        animator.SetTrigger("patear");

    }
    //0,804 0,962 -  0,106  0,05

    public void Soltar()
    {
        rb.AddTorque(0, 0, torque * equipo, ForceMode.Force);
    }

    
}
