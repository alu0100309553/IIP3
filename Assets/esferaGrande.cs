using UnityEngine;
using System.Collections;

public class esferaGrande : MonoBehaviour {

	void OnEnable(){
		Colision.Eventodos += EsferaMetodo;
	}
	void Start () {

	}

	void EsferaMetodo (ControllerColliderHit hit){
		if (hit.gameObject.tag == gameObject.tag) {
			gameObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1);
			gameObject.GetComponent<Rigidbody> ().useGravity = true;
			gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		}

	}
	// Update is called once per frame
	void Update () {

	}
}
