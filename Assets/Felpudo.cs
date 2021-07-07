using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felpudo : MonoBehaviour {

    public GameObject cameraPrincipal;

    public AudioClip somBate;
    public AudioClip somPonto;
    public AudioClip somVoa;

    // Use this for initialization
    void OnTriggerEnter (Collider objeto) {
		
        if(objeto.gameObject.tag == "Finish")
        {
           GetComponent<Rigidbody>().velocity = Vector3.zero;
           GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 8.50f, -10.0f);
           GetComponent<Rigidbody>().AddTorque(new Vector3(-100.0f, -100.0f, -100.0f));

            cameraPrincipal.SendMessage("FimDeJogo");
            GetComponent<AudioSource>().PlayOneShot(somBate);
        }
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider objeto) {

        if (objeto.gameObject.tag == "GameController")
        {
            Destroy(objeto.gameObject);
            cameraPrincipal.SendMessage("MarcaPonto");
            GetComponent<AudioSource>().PlayOneShot(somPonto);
        }

        
    }
    void SomVoa()
    {
        GetComponent<AudioSource>().PlayOneShot(somVoa);
    }
}
