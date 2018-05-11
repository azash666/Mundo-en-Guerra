using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad : MonoBehaviour {
	private Vector3 direccionAlCentro;
	private Rigidbody rb;
	private bool colisiona;
	private int dentro;
	public float valorGravedad;
	public GameObject tocaSuelo;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (!tocaSuelo.GetComponent<detectaRueda> ().toca) {
			direccionAlCentro = (transform.position).normalized;
			rb.AddForce (-direccionAlCentro * valorGravedad);
		//}
	}
		
}
