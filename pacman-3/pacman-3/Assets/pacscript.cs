using UnityEngine;
using System.Collections;

public class Pacscript : MonoBehaviour {

	public float movementSpeed = 10;
	
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

	void OnCollisonEnter(Collision other){
		Debug.Log("shit");
		if (other.gameObject.CompareTag("door")){
			Destroy(other.gameObject);
		}
	}
}
