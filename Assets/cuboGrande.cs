using UnityEngine;
using System.Collections;

public class cuboGrande : MonoBehaviour {

	// Use this for initialization
	void OnEnable(){
		Colision.Eventodos += CuboMetodo;
	}
	void Start () {
		
	}

	void CuboMetodo (ControllerColliderHit hit){
		if (hit.gameObject.tag == gameObject.tag) {
			gameObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1);
			//gameObject.GetComponent<Rigidbody> ().useGravity = true;
			//gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			gameObject.GetComponent<Transform> ().rotation = new Quaternion (45, 45, 45, 1);
		}
	
	}
	// Update is called once per frame
	void Update () {

	}
}
