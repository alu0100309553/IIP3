using UnityEngine;
using System.Collections;

public class CuboColores : MonoBehaviour {
	public Material colorInicio;

	// Use this for initialization
	void Start () {
		GameController.Evento += MetodoEjecutar;
		Colision.Eventodos += OtroMetodo;
		gameObject.GetComponent<Renderer>().material = colorInicio;
	}
	void MetodoEjecutar(){
		gameObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1);
	
	}
	void OtroMetodo(ControllerColliderHit hit){
		if (hit.gameObject.name == gameObject.name) {
			gameObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1);
		
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
