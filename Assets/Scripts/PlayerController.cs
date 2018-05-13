using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	private int count;

	public Text countText, winText;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void Update(){
		// Called before rendering a Frame
	}

	void FixedUpdate() {
		// Called before performing any physics calculations
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);
			count++;
			SetCountText ();
			if (count == 12) {
				winText.text = "You've won";
			}
		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
	}
}
