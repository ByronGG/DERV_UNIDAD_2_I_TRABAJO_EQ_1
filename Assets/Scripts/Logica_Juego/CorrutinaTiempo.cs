using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrutinaTiempo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text_tiempo;
    int cont_tiempo;
    // Start is called before the first frame update
    void Start()
    {
        cont_tiempo = 1;
        StopAllCoroutines();
        StartCoroutine("coRuntinaTiempo");
    }

    

    IEnumerator coRuntinaTiempo()
    {
        while (true)
        {
            text_tiempo.text = cont_tiempo.ToString();
            cont_tiempo++;
            yield return new WaitForSeconds(.5f);
        }
    }
}