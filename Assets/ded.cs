using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ded : MonoBehaviour {

	public GameObject Player;
	public GameObject Ragdoll;
	public GameObject dead;

	void OnTriggerEnter(Collider other){
		if (other.tag == "dest") {
			Player.SetActive (false);
			Ragdoll.SetActive (true);
			Instantiate(Ragdoll, transform.position, transform.rotation);
			Destroy (dead);
		}
	}

}
