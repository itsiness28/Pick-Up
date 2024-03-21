using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuInicial : MonoBehaviour
{
   
    public void jugar() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
    


}
    



