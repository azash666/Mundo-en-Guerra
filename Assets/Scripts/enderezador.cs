using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enderezador : MonoBehaviour {
	// Use this for initialization
	void Start () {
		transform.up = (transform.position).normalized;
		float tam = transform.position.magnitude - 500f;
		Vector3 aux = transform.position.normalized*(-tam);
		transform.position = transform.position + aux;
	}

}
