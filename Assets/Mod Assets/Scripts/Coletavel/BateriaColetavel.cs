using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateriaColetavel : ItemColetavel
{
	// Start is called before the first frame update
    public override void Start()
    {
        audioS = GetComponent<AudioSource>();
		pickup = "Battery";
		
		vetorRotacao = Vector3.back;
		oscilacao = 0.0027f;
    }
}
