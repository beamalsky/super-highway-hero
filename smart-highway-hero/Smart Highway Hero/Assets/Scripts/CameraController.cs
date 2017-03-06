using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Rigidbody rb;
	public GameObject player;
	public float speed;
	private Vector3 offset;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0.0f, 0.0f, speed);
	}
}
