using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrella : MonoBehaviour {
	public Vector3 baseA, baseB;
	public int numJugadores;
	public Vector3[] basesIntermedias;
	public bool finalizado;
	// Use this for initialization
	void Start () {
		finalizado = false;
		baseA = new Vector3 (0, 500, 0);
		baseB = new Vector3 (0, -500, 0);
		int num = numJugadores + 2;
		basesIntermedias=new Vector3[num];
		float angulo = 360f / 10;
		for (int i = 0; i < num; i++) {
			float x, y, z;
			x = 500*Mathf.Sin (63f * Mathf.Deg2Rad) * Mathf.Cos ((float)i  * Mathf.Deg2Rad*angulo);
			z = 500*Mathf.Sin (63f * Mathf.Deg2Rad) * Mathf.Sin ((float)i  * Mathf.Deg2Rad*angulo);
			y = 500*Mathf.Cos (63f * Mathf.Deg2Rad);
			if (i % 2 == 0)
				y = -y;
			basesIntermedias [i] = new Vector3 (x, y, z);
		}
		finalizado = true;
	}

}
