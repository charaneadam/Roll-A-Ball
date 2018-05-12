using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		// Runs every frame just like update, but it is guaranteed 
		// it will be ran after all items have been processed in update
		this.transform.position = player.transform.position + offset;
	}
}
