using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoover : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.material.color = Color.black;
	}
	void OnMouseEnter() {
		rend.material.color = Color.red;
	}
	void OnMouseExit() {
		rend.material.color = Color.black;
	}
		
}
