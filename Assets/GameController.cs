using UnityEngine;
using System.Collections;
public delegate void metodoDelegado ();

public class GameController : MonoBehaviour {
	public static event metodoDelegado Evento;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("mouse 0")){
			Evento ();
		}
	
	}
}
