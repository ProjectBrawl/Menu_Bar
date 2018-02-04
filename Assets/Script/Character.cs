using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Rigidbody rigb;
    Physics phys;
	public float maxSpeed = 2f;
	// Use this for initialization
	void Start ()
    {
        rigb = this.GetComponentInParent<Rigidbody>();
        phys = this.GetComponentInParent<Physics>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 f = new Vector3(x, 0.0f, z);
        f *= 20;
        rigb.AddForce(f);
		if(rigb.velocity.magnitude > maxSpeed)
		{
			rigb.velocity = rigb.velocity.normalized * maxSpeed;
		}
    }
		
}
