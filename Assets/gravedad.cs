using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad : MonoBehaviour {
	private Vector3 direccionAlCentro;
	private Rigidbody rb;
	private bool colisiona;
	private int dentro;
	public float valorGravedad;
	public GameObject centro;
	// Use this for initialization
	void Start () {
		dentro = 0;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if(!colisiona)
		direccionAlCentro = (transform.position - centro.transform.position).normalized;
		rb.AddForce (-direccionAlCentro * valorGravedad);
	}

	private void OnCollisionEnter(Collision collider){
		if (collider.gameObject.tag == "Suelo")
			dentro++;
		if (dentro > 0)
			colisiona = true;
	}


	private void OnCollisionExit(Collision collider){
		if (collider.gameObject.tag == "Suelo")
			dentro--;
		if (dentro <= 0)
			colisiona = false;
	}
}
