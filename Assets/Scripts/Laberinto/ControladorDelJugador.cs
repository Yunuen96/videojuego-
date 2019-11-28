using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDelJugador : MonoBehaviour
{

    public float velocidad = 10;
    public Text textomonedas;
    public Text textovictorias;
    public string SiguienteEscena="";
    int monedas = 0;
	public GameObject regresar;
	public GameObject siglvl;



    Rigidbody miRigiBoody;
    Vector3 posicionInicial;
    bool hasalido;
    


    // Use this for initialization
    void Start()
    {
        miRigiBoody = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
        textovictorias.enabled = false;
        hasalido = false;
		regresar = GameObject.Find ("regresar");
		siglvl = GameObject.Find ("siglvl");
		regresar.SetActive (false);
		siglvl.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasalido)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            miRigiBoody.MovePosition(miRigiBoody.position+ new Vector3(horizontal, 0, vertical) * velocidad*Time.deltaTime);
            miRigiBoody.velocity = Vector3.zero;
            miRigiBoody.angularVelocity = Vector3.zero;
        }

    }

    private void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("Salida"))
        {
            hasalido = true;
            textovictorias.enabled = true;
			regresar.SetActive (true);
			siglvl.SetActive (true);
            miRigiBoody.velocity = Vector3.zero;
            miRigiBoody.angularVelocity = Vector3.zero;
            SceneManager.LoadScene(SiguienteEscena);
        }
        else if (otro.CompareTag("Enemigo"))
        {
            miRigiBoody.MovePosition(posicionInicial);
            miRigiBoody.velocity = Vector3.zero;
            miRigiBoody.angularVelocity = Vector3.zero;
            monedas = 0;
            textomonedas.text = "Monedas: 0";
        }
        else if (otro.CompareTag("Moneda"))
        {
            otro.gameObject.SetActive(false);
            monedas = monedas + 1;
            textomonedas.text = "Modedas: " + monedas;

        }
    }
}
