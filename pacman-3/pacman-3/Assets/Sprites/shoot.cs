using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public float movementSpeed = 1;

	void Update(){

		transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log (col.gameObject);
		Debug.Log (gameObject);
		if(gameObject.tag == "bullet")
		{
			Debug.Log ("dis");
			transform.Rotate (0, 0, 180f);
		}
		if(col.gameObject.tag == "character")
		{
			Time.timeScale = 0;
			//col.gameObject.active = false;
		}
	}
}