using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
	public int winningPlayer = 0;
	
	public void CheckpointPlayer(int playerNumber)
	{
		winningPlayer = playerNumber;
	}
}
