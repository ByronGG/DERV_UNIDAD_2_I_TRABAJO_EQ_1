using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colissiones_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;

        if (tag.Equals("Enemigo_TAG")) //Si colisiona con un enemigo entonces...
        {
            GameObject obj_a_destruir;
            obj_a_destruir = GameObject.Find(name);

            if(obj_a_destruir != null)
            {
                //Destruye el objeto 5 segundo despues de colisionar con el
                //Destroy(obj_a_destruir, 5);
                Destroy(obj_a_destruir);
                Debug.Log("Mamo el enemigo");
            }
        }
    }

    private void OnCollisionStay (Collision collision)
    {

    }

    
}
