using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;

	public float health = 100;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Mouse0))
		{
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);

			if(MyGlobal.Global.player_moves)
				MyGlobal.Global.player_moves = false;
			else
				MyGlobal.Global.player_moves = true;
		}
	}


}
