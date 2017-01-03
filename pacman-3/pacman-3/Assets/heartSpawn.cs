using UnityEngine;
using System.Collections;

public class heartSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		spawnElements ();
	}

	void spawnElements(){
		float randX = (float) 0.01 * Random.Range (-70, 100);
		float randY = (float) 0.01 * Random.Range (-110, 110);
		transform.position = new Vector3(randX, randY, 0f);
	}

	void onTriggerEnter(Collider colElement){
		if (colElement.gameObject.name == "doorSpawn") {
			spawnElements ();
		}
		if (colElement.gameObject.name == "maze") {
			spawnElements ();
		} else {
			pickup ();
		}
	}

	void pickup(){
	}


	// Update is called once per frame
	void Update () {

	}
}
