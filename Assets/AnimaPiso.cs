using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaPiso : MonoBehaviour {

    public Material materialPiso;
    private float velocidade = 0.75f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float offSet = Time.time *  velocidade;
        materialPiso.SetTextureOffset("_MainTex", new Vector2(offSet,0));
		
	}
}
