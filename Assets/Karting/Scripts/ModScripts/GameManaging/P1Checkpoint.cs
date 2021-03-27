using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Checkpoint : MonoBehaviour
{
	[SerializeField]
	WinCondition WC;
	
    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Checkpoint")
		{
			Destroy(other);
			WC.CheckpointPlayer(1);
		}
	}
}
