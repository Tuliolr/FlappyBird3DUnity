using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z < -20f)
        {
            Destroy(this.gameObject);
        }
	}
}
