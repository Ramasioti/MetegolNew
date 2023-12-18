using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seleccion : MonoBehaviour
{

    public Movimiento[] palos;

    bool left, right;


    int palosSelecionado;

    public KeyCode patear;
    public KeyCode arriba;
    public KeyCode abajo;
    public KeyCode derecha;
    public KeyCode izquierda;


    
    void Start()
    {
        right = left = true;
    }

   
    void Update()
    {
        selecion();
    }

    private void selecion()
    {
        if (Input.GetKeyDown(derecha) && palosSelecionado!= palos.Length-1)
        {
            palosSelecionado++;
        } 
        if ( Input.GetKeyDown(izquierda) && palosSelecionado != 0)
        {
            palosSelecionado--;
        } 
       
        if ( Input.GetKey(arriba) && right )
        {
            palos[palosSelecionado].movimiento(1);
        } 
        if ( Input.GetKey(abajo) && left)
        {
            palos[palosSelecionado].movimiento(-1);
        }
        if ( Input.GetKeyDown(patear))
        {
            palos[palosSelecionado].patear();
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Left"))
        {
            left = false;

        }
        if (other.CompareTag("Right"))
        {
            right = false;
            Debug.Log("anda");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Left"))
        {
            left = true;
        }
        if (other.CompareTag("Right"))
        {
            right = true;
        } 
    }

}
