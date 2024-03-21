using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] imagenes;
    public Slider[] sliders;
    Vector3[] posInicial;
    RectTransform[] rectTransform;
    public float umbral= 0.05f;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = new Vector3[imagenes.Length];
        rectTransform = new RectTransform[imagenes.Length];
        for (int i = 0; i < imagenes.Length; i++)
        {
            posInicial[i] = imagenes[i].transform.position;
            rectTransform[i] = imagenes[i].GetComponent<RectTransform>();
        }

        foreach(Slider slider in sliders)
        {
            slider.minValue = UnityEngine.Random.Range(-3f, 0f);
            slider.maxValue = UnityEngine.Random.Range(0f, 3f);
            slider.value = UnityEngine.Random.Range(slider.minValue,  slider.maxValue);
        }

        ActualizarImagenes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void ActualizarImagenes()
    {
        bool puzzlecorrecto = true;
        for (int i = 0; i < imagenes.Length; i++)
        {
            if (MathF.Abs(sliders[i].value)<umbral) { sliders[i].value = 0; }
            else { puzzlecorrecto = false; }
            MoverImagen(i, sliders[i].value);
        }
        if (puzzlecorrecto) { print("Has ganado"); }
       

    }

    void MoverImagen(int i, float valor)
    {
        imagenes[i].transform.position = new Vector3(posInicial[i].x + rectTransform[i].rect.width * valor,
                                                imagenes[i].transform.position.y, imagenes[i].transform.position.z);
    }

}
