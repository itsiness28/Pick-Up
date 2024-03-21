using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diferencias : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject differencefoundspriteclon;
    public SpriteRenderer imageoriginal;
    public SpriteRenderer imagemodified;
    public GameObject objecttomatch;


    private void Start()
    {
        if (imageoriginal==null || imagemodified==null || objecttomatch== null|| differencefoundspriteclon == null)
        {
            Debug.Log("No he asignado algun componente en el inspector");
            return;
        }
        adjustimagentocollider();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 clickposition= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickposition, Vector2.zero);
            
            
                if (hit.collider !=null && hit.collider.gameObject.tag == "difference") 
                {
                    showdifferencesprite(hit.collider.gameObject.transform.position);
                }
            

        }
    }

    void showdifferencesprite(Vector2 position) 
    {
        GameObject differencefound = Instantiate(differencefoundspriteclon, position, Quaternion.identity);
        Destroy(differencefound, 1.0f);

    }
    bool finddiferencebetween()
    {
        Texture2D texture1 = imageoriginal.sprite.texture;
        Texture2D texture2 = imagemodified.sprite.texture;
        if (texture1.width != texture2.width || texture1.height != texture2.height)
        {
            Debug.Log("Las imagenes tienen tamaños diferentes");
            return false;
        }
        bool differencefound = false;
        for (int i = 0;i<texture1.width;i++)
        {
            for (int j = 0; j < texture2.height; j++)
            {
                Color pixelColor1 = texture1.GetPixel(i, j);
                Color PixelColor2 = texture2.GetPixel(i, j);
                if (pixelColor1 != PixelColor2)
                {
                    differencefound = true;
                }
            }
        }
        return differencefound;
    }
    void adjustimagentocollider()
    {
        Collider collider = objecttomatch.GetComponent<Collider>();
        if (collider == null)
        {
            Debug.Log("No tiene caja de colision donde has clicado");
                return;
        }
        Vector3 collidersize= collider.bounds.size;
        Vector3 newScael = new Vector3(collidersize.x, collidersize.y, 1f);
        imagemodified.transform.localScale = newScael;
        imageoriginal.transform.localScale = newScael;

    }

}
