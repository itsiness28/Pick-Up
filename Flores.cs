using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flores : MonoBehaviour
{
    public GameObject[] flowers;
    public float contadorclicks = 0;
    public float sumatorioclicks = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clickenpantalla();
        apariciondejarron();
    }
    void clickenpantalla()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickposition, Vector2.zero);


            if (hit.collider != null && hit.collider.gameObject.tag == "difference")
            {
                contadorclicks++;
            }
        }
    }
    void apariciondejarron() 
    {
        for (int i = 0; i < flowers.Length; i++)
        {
            sumatorioclicks += contadorclicks;
        }
    
    }
}
