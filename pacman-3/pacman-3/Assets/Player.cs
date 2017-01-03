using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float movementSpeed = 10;
	public bool hasKey = false;
	public bool doorOpened = true;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKey("right")){
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey("down")){
			transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey("left")){
			transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey("up")){
			transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "door" && hasKey){
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "key") {
			Destroy (other.gameObject);
			hasKey = true;
		}
	}

}
