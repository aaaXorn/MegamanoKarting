using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
	[SerializeField]
	string itemTest;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void TestCollected()
	{
		itemTest = "test";
	}
	
	public void BatteryCollected()
	{
		itemTest = "battery";
	}
	
	public void BusterCollected()
	{
		itemTest = "buster";
	}
}
