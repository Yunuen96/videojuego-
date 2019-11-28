using UnityEngine;
using System.Collections;

public class CambioCamara : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	void Start()
	{
		cam1.GetComponent<Camera> ().enabled = true;
		cam2.GetComponent<Camera> ().enabled = false;
	}

	void Update()
	{
		if (Input.GetKeyDown("x"))
		{
			if (cam1.GetComponent<Camera> ().enabled == true)
			{
				cam1.GetComponent<Camera> ().enabled = false;
				cam2.GetComponent<Camera> ().enabled = true;
			}
			else if (cam2.GetComponent<Camera> ().enabled == true)
			{
				cam2.GetComponent<Camera> ().enabled = false;
				cam1.GetComponent<Camera> ().enabled = true;
			}
		}
	}
}
