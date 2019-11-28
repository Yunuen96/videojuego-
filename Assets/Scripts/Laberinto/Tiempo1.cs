using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo1 : MonoBehaviour {
	public Text timer;
	private float startTim;
	public float tiem = 60;
	public string nevel;

	void Start()
	{
		startTim = Time.time;
		StartCoroutine(tempo());
	}

	IEnumerator tempo()
	{
		yield return new WaitForSeconds(tiem);
		Application.LoadLevel(nevel);


	}

	void Update()
	{

		float ti = Time.time - startTim;

		string minutes = ((int)ti / 60).ToString();
		string seconds = (ti % 60).ToString("f2");

		timer.text = minutes + ":" + seconds;
	}
}
