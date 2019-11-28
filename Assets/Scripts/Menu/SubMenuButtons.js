
function Regresar(){
	Application.LoadLevel("menu");
}

function Juego1(){
	Destroy (GameObject.FindWithTag("musica"));
	Application.LoadLevel("Lab1");
}

function Juego2(){
	Destroy (GameObject.FindWithTag("musica"));
	Application.LoadLevel("puzzle");
}