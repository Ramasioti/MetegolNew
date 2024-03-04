using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Revancha : MonoBehaviour
{
    public void revancha()
    {
        SceneManager.LoadScene(1);
    }

    public void inicio()
    {
        SceneManager.LoadScene(0);
    }

 
}
