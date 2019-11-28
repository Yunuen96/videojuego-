using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle1 : MonoBehaviour {

	//Variables para movimiento de las fichas
	public bool mover;
	public Transform slot;
	float x;
	float y;

	//Variables para verificar el tag del objeto
	public string tagObjeto;
	public string tagObjeto1;

	//Variables para modificar el script Aciertos
	public GameObject script;
	Aciertos modificar;

	//Variables para mostrar texto al completar puzzle
	public GameObject Canvas;
	public GameObject regresar;
	public GameObject siglvl;
	public GameObject final;
	Text texto;


	void Start(){
		mover = true;
		tagObjeto = gameObject.tag;

		modificar = script.GetComponent<Aciertos> ();
		texto = Canvas.GetComponent<Text> ();

		texto.text = "";

		regresar = GameObject.FindWithTag ("regresar");
		regresar.SetActive (false);
		siglvl = GameObject.FindWithTag ("siglvl");
		siglvl.SetActive (false);
	}

	void Update(){
		if (modificar.puntos == 8) {
			texto.text = "¡Has Ganado!";
			mover = false;
			regresar.SetActive (true);
			siglvl.SetActive (true);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == tagObjeto) {
			modificar.puntos += 1;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == tagObjeto) {
			modificar.puntos -= 1;
		}
	}

	void OnMouseUp (){
		if (mover == true) {
			if (Vector3.Distance(transform.position, slot.position) == 1) {
				x = transform.position.x;
				y = transform.position.y;

				transform.position = new Vector3 (slot.position.x, slot.position.y, 0);

				slot.position = new Vector3 (x, y, 0);
			}
		}
	}
}
