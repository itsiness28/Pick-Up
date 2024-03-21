using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaCajas : MonoBehaviour
{
    Collider2D colliderx;
    public SpriteRenderer sr;
    public float normalO, ampliadoO, normalS, ampliadoS;
    // Start is called before the first frame update
    void Start()
    {
       colliderx = GetComponent<Collider2D>();
        sr.enabled = false;
        normalO = colliderx.offset.y;
        //normalS = colliderx.bounds.size.y;

    }

    // Update is called once per frame
    void Update()
    {
        HacerVisible();
    }
    void HacerVisible()
    {
        
    }
    void colision2D()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pastilla")
        {
            colliderx.offset = new Vector2(colliderx.offset.x, ampliadoO);
            sr.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "pastilla")
        {
            colliderx.offset = new Vector2(colliderx.offset.x, normalO);
            sr.enabled = false;
        }
    }
}
