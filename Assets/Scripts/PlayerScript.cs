using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;
	public float health = 100;

	public PlayerScript() {
		health = 100;
	}
		


	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Mouse0))
		{
			if (SceneGlobals.Global.playerCanShoot) {
				
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
				SceneGlobals.Global.playerCanShoot = false;
			}

		}
	}


}
