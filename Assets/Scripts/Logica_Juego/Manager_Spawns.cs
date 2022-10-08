using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Spawns : MonoBehaviour
{
    [SerializeField]
    List<Transform> spawns;

    [SerializeField]
    GameObject a_quien_crear; //Agregar por inspector 

    private void Awake()
    {
        spawns = new List<Transform>();
        for (int i = 1; i <= 4; i++)
        {
            GameObject temp = GameObject.Find("Spawn_Area_" + i);
            spawns.Add(temp.transform);
        }
    }
    [SerializeField]
    int contador;

    public void crearEnemigo() //Crear un if con método random para generar enemigo o power-up
    {
        int indice = Random.Range(0, spawns.Count);
        Transform temp = spawns[indice];

        GameObject objCreado = Instantiate(a_quien_crear,
            temp.position, temp.rotation);
        objCreado.name = "Enemigo_" + contador;
        contador++;
    }

    // Start is called before the first frame update
    void Start()
    {
        crearEnemigo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
