
using UnityEngine;
using System.Collections;


public class Disparador : MonoBehaviour {
	public GameObject objeto1;
	public GameObject objeto2;
	public GameObject objeto3;
	private bool dentro = false;
	void OnTriggerEnter (){
		//for (int i = 0; i < 10; i++) {
		if (!dentro){
			for (int i = 0; i < 5; i++) {
				Instantiate (objeto1, new Vector3 (transform.position.x - Random.Range (-125.0f, 125.0f), 15, transform.position.z - Random.Range (-50.0f, 50.0f)), Quaternion.identity);
				Instantiate (objeto2, new Vector3 (transform.position.x - Random.Range (-125.0f, 125.0f), 15, transform.position.z - Random.Range (-50.0f, 50.0f)), Quaternion.identity);
				Instantiate (objeto3, new Vector3 (transform.position.x - Random.Range (-125.0f, 125.0f), 15, transform.position.z - Random.Range (-50.0f, 50.0f)), Quaternion.identity);
			}
			dentro = true;
		}
	}
	void OnTriggerStay(){
	
		//	GameObject este = (GameObject)Instantiate (objeto, transform.position, Quaternion.identity);
	}
	void OnTriggerExit(){
		dentro = false;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
