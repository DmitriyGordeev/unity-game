using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;
	public float health = 100;

	
	// Update is called once per frame
	void Update () {

		if (SceneGlobals.Global.enemyWasHit) {
			if (SceneGlobals.Global.enemyCanShoot) {
				
				ProjectileMover pm = Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as ProjectileMover;
				pm.velocity = -7;
				SceneGlobals.Global.enemyCanShoot = false;
			}
		}
	
	}


}
