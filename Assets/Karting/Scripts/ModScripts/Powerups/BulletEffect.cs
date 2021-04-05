using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class BulletEffect : MonoBehaviour
{
	float timer = 6;
	
	Rigidbody rigidB;
	
    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		rigidB.velocity = -transform.up * 17;
		
        timer -= Time.deltaTime;
		if(timer < 0)
		{
			Destroy(gameObject);
		}
    }
	
	private void OnTriggerEnter(Collider other)
    {
        var rb = other.attachedRigidbody;
        if (rb) {

            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            { 
                kart.SetStun(true);

                Destroy(gameObject);
            }
        }
    }
}
