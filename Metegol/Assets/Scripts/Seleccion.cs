using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seleccion : MonoBehaviour
{

    public Movimiento[] palos;

    bool left, right;

    public Material materialSelecionado;
    public Material materialNoSelecionado;

    int palosSelecionado;

    public KeyCode patear;
    public KeyCode arriba;
    public KeyCode abajo;
    public KeyCode derecha;
    public KeyCode izquierda;

    
    
    void Start()
    {
        right = left = true;
        palosSelecionado = 2;
    }

   
    void Update()
    {
        selecion();
    }

    private void selecion()
    {
        if (Input.GetKeyDown(derecha) && palosSelecionado!= palos.Length-1)
        {
            ChangeColor(materialNoSelecionado);
            palosSelecionado++;
            ChangeColor(materialSelecionado);
        } 
        if ( Input.GetKeyDown(izquierda) && palosSelecionado != 0)
        {
            ChangeColor(materialNoSelecionado);
            palosSelecionado--;
            ChangeColor(materialSelecionado);
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

    private void ChangeColor(Material material)
    {
        palos[palosSelecionado].GetComponent<MeshRenderer>().material = material;
    }


   

}
