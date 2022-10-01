using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Puntaje : MonoBehaviour
{
    public float puntos; //Valor del enemigo
    public TextMeshProUGUI txtPuntos; //TxMPRO para mostarar el puntaje en pantalla

    private void Update()
    {
        txtPuntos.text = "SCORE " + puntos.ToString(); //En el TextMeshPro se toma el valor (float o int) del puntaje y se pasa a un string para monstrarlo a pantalla
    }
}
