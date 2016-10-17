using UnityEngine;
using System.Collections;
public delegate void metodoDelegadodos (ControllerColliderHit hit);

public class Colision : MonoBehaviour {
	public static event metodoDelegadodos Eventodos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void  OnControllerColliderHit(ControllerColliderHit hit){
		Eventodos (hit);
	
	}
}
