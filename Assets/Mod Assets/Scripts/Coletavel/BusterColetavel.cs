using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterColetavel : ItemColetavel
{
    // Start is called before the first frame update
    public override void Start()
	{
		audioS = GetComponent<AudioSource>();
		pickup = "Buster";
		
		vetorRotacao = Vector3.up;
		oscilacao = 0.001f;
	}
}
