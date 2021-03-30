using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class ItemBehaviour : MonoBehaviour
{
	public string currentItem = "none";
	
	[SerializeField]
	Rigidbody rigidB;
	
	[SerializeField]
	string fireKey;
	
	[SerializeField]
	Transform playerPos;
	
	[SerializeField]
	GameObject Armadilha, PewPew;
	
	public ArcadeKart.StatPowerup batteryStats = new ArcadeKart.StatPowerup
	{
		
	};
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		var aKart = rigidB.GetComponent<ArcadeKart>();
		
		if (Input.GetKeyDown(fireKey) && currentItem != "none" && aKart)
		{
			switch (currentItem)
			{
				case "battery":
					aKart.AddPowerup(this.batteryStats);
					break;
				
				case "trap":
					GameObject Trap = Instantiate(Armadilha, playerPos.transform.position, playerPos.transform.rotation);
					Trap.transform.Translate(0, -0.8f, -3);
					break;
					
				case "buster":
					/*GameObject Tiro = Instantiate(PewPew, playerPos.transform.position, playerPos.transform.rotation);
					Tiro.transform.Translate(0, 0, 0);
					Tiro.rigidB.velocity = new Vector3(0, 0, 0);*/
					break;
				
				default:
					break;
			}
			
			currentItem = "none";
		}
    }
	
	public void TestCollected()
	{
		currentItem = "test";
	}
	
	public void BatteryCollected()
	{
		currentItem = "battery";
	}
	
	public void BusterCollected()
	{
		currentItem = "buster";
	}
	
	public void TrapCollected()
	{
		currentItem = "trap";
	}
}