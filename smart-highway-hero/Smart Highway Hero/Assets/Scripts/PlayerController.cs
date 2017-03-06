using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
	public float xMin, xMax;	
}

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private Transform tf;
	public Boundary boundary;

	public float laneWidth;
	public float speed;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		tf = GetComponent<Transform> ();
		rb.velocity = new Vector3 (0.0f, 0.0f, speed);
	}

	void Update () {
		
		if (Input.GetKeyDown("z")) {
			tf.position = new Vector3 (tf.position.x - laneWidth, tf.position.y, tf.position.z);
		}

		if (Input.GetKeyDown("x")) {
			tf.position = new Vector3 (tf.position.x + laneWidth, tf.position.y, tf.position.z);
		}

		tf.position = new Vector3 (
			Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 
			2.0f, 
			tf.position.z
		);
	}
}
