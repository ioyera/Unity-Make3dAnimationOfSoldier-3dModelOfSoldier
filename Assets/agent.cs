using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent : MonoBehaviour {
	public GameObject bib;
	public NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		nav = this.GetComponent<NavMeshAgent>();
	
	}
	
	// Update is called once per frame
	void Update () {
		nav.destination = bib.transform.position;

	}
}
