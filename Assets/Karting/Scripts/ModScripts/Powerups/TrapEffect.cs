using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class TrapEffect : MonoBehaviour
{

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
