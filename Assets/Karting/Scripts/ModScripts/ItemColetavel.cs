using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemColetavel : MonoBehaviour
{
	public AudioSource audioS;
	public string pickup;
	public Vector3 vetorRotacao;
	public float oscilacao;
	
    public abstract void Start();
	//template pra usar no "public override void Start()" dos pickups
	/*
	{
		audioS = GetComponent<AudioSource>();
		pickup = "Test";
		
		vetorRotacao = Vector3.up;
		oscilacao = 0.001f;
	}
	*/

    // Update is called once per frame
    void Update()//anima o pickup com transform
    {
        transform.Rotate(vetorRotacao * Time.deltaTime * 160);
		transform.position += Vector3.up * Mathf.Sin(Time.time) * oscilacao;
    }
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.SendMessage(pickup + "Collected");
			audioS.Play();
			Destroy(gameObject, 0.3f);
		}
	}
}
