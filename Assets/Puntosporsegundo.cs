using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntosporsegundo : MonoBehaviour
{
    public float puntos = 0f;

    public Text variableText;

    // Update is called once per frame
    void Update()
    {
        puntos += Time.deltaTime;
        variableText.text = "Puntuación : " + puntos;
    }
}
