#pragma strict
var vel : int = 3;		
var objeto : Transform;

function Start () {
	
}

function Update () {
	if (Input.GetKeyDown("mouse 0")){
		var generar = Instantiate (objeto, transform.position, Quaternion.identity);
		generar.GetComponent.<Rigidbody>().AddForce(transform.forward * 2000 * vel);
	}
}