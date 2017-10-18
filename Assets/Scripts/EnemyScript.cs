using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;
	public int health = 100;

	
	// Update is called once per frame
	void Update () {

		if (!MyGlobal.Global.player_moves) 
		{
			ProjectileMover pm = Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as ProjectileMover;
			pm.velocity = -7;

			if(MyGlobal.Global.player_moves)
				MyGlobal.Global.player_moves = false;
			else
				MyGlobal.Global.player_moves = true;
		}


	}


}
