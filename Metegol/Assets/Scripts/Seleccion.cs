using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seleccion : MonoBehaviour
{

    public Movimiento[] palos;
    


    int palosSelecionado;

    public KeyCode patear;
    public KeyCode arriba;
    public KeyCode abajo;
    public KeyCode derecha;
    public KeyCode izquierda;


    
    void Start()
    {
        
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
       
        if ( Input.GetKey(arriba))
        {
            palos[palosSelecionado].movimiento(1);
        } 
        if ( Input.GetKey(abajo))
        {
            palos[palosSelecionado].movimiento(-1);
        }
        if ( Input.GetKeyDown(patear))
        {
            palos[palosSelecionado].patear();
        }
    }



}
