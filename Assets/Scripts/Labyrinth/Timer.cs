using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timerText;
    private float startTime;
    public float tiempo = 60;
    public string nivel;

	void Start () {
        startTime = Time.time;
        StartCoroutine( tempori ());
	}

    IEnumerator tempori()
    {
        yield return new WaitForSeconds(tiempo);
        Application.LoadLevel(nivel);


    }
	
	void Update () {
       
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;        
	}

}
