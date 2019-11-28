using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour {

    // Use this for initialization
    public Transform desde;
    public Transform hasta;
    public float velocidad=5;
    bool llendo;
	void Start () {
        llendo = true; 
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 objetivo;
        if (llendo)
        {
            objetivo = hasta.position;

        }
        else
        {
            objetivo = desde.position;
        }
        Vector3 distancia = objetivo - transform.position;
        Vector3 desplazamiento = distancia.normalized * velocidad * Time.deltaTime; 
        if (desplazamiento.sqrMagnitude >= distancia.sqrMagnitude)
        {
            desplazamiento = distancia;
        }
        transform.position = transform.position + desplazamiento;

        if (desplazamiento.sqrMagnitude < 0.00001)
        {
            llendo = !llendo;
        }
	}
}
