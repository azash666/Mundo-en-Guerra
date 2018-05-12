using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad : MonoBehaviour {
	private Vector3 direccionAlCentro;
	private Rigidbody rb;
	public bool colisiona;
	private int dentro;
	private float tiempo;
	public float valorGravedad;
	public GameObject tocaSuelo;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tiempo = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		colisiona = tocaSuelo.GetComponent<detectaRueda> ().toca;
		if (!colisiona) {
			//if (tiempo <= Time.time) {
			direccionAlCentro = (transform.position).normalized;
			rb.AddForce (-direccionAlCentro * valorGravedad * rb.mass);
			//transform.position=transform.position-direccionAlCentro*valorGravedad*Time.deltaTime;
			//tiempo += 0.2f;
		} else {
			rb.velocity = new Vector3 (0, 0, 0);
		}
		//}
	}
		
}
