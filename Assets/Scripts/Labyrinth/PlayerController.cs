using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
    public float speed;
	public Text countText;
	public Text winText;
	public GameObject regresar;
	public GameObject siglvl;
	private int count;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
		regresar = GameObject.FindGameObjectWithTag ("regresar");
		regresar.SetActive (false);
		siglvl = GameObject.FindGameObjectWithTag("siglvl");
		siglvl.SetActive (false);

	}

    void FixedUpdate()
    {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

			rb.AddForce (movement * speed);
    }

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();

		}
	}
	void SetCountText (){
		if (count >= 1) {
			winText.text = "¡Felicidades!";
			regresar.SetActive (true);
			siglvl.SetActive (true);
		}
	}
}