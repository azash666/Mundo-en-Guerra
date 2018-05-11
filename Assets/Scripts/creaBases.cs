using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaBases : MonoBehaviour {

	public GameObject objetoBase;
	public bool finalizado;
	private estrella estrella;
	// Use this for initialization
	void Start () {
		finalizado = false;
		estrella=GetComponent<estrella> ();
	}

	// Update is called once per frame
	void Update () {
		if (estrella.finalizado && !this.finalizado) {
			Instantiate (objetoBase, estrella.baseA, new Quaternion(0,0,0,0));
			Instantiate (objetoBase, estrella.baseB, new Quaternion(0,0,0,0));
			for(int i=0; i<10; i++){
				Instantiate(objetoBase, estrella.basesIntermedias[i], new Quaternion(0,0,0,0));
			}
			finalizado = true;
		}
	}
}
