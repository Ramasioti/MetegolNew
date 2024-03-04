using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gol : MonoBehaviour
{

    public TextMeshProUGUI anotador;

    int goles;

    public Transform inicio;

    public GameObject panel;

    public int win;

    public GameObject pelota;

    void Start()
    {
        
    }

   
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pelota"))
        {
            goles++;
            anotador.text = goles.ToString();   

            other.transform.position = inicio.position;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;

            if(goles >= win) 
            {
            panel.SetActive(true);
            }

        }
    }

    public void VolverIniciar()
    {
       pelota.transform.position = inicio.position;
       pelota.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    

}
