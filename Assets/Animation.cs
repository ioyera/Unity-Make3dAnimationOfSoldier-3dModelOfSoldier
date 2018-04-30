using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour {

	Animator anim;
	[SerializeField]
	private float speed =5;
	private float x;
	private float z;
	public Image GameOverImage; 

	public Rigidbody MyRigidBody{ get;set; }
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
		MyRigidBody = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {
		anim.SetFloat("moveH",Input.GetAxis("Horizontal"));
		anim.SetFloat("moveV",Input.GetAxis("Vertical"));
		x = Input.GetAxis("Horizontal") * speed*  Time.deltaTime; 
		z = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
		transform.Translate(x, 0, z);
	}
	void OnCollisionExit(Collision other){
		if (other.gameObject.tag == "dest") {
			GameOverImage.gameObject.SetActive (true);
			Debug.Log("kerghliuehrlgiu");
		}
	}
}
