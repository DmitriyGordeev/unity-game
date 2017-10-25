using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;
	public float health = 100;

	IEnumerator Reset(float Count) {
		yield return new WaitForSeconds(Count);
		Attack ();
		yield return null;
	}


	void Attack() {
		ProjectileMover pm = Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as ProjectileMover;
		pm.velocity = -7;
		pm.damage = 10;
	}

	
	// Update is called once per frame
	void Update () {

		if (SceneGlobals.Global.enemyWasHit) {
			if (SceneGlobals.Global.enemyCanShoot) {
				StartCoroutine ("Reset", 1);
				SceneGlobals.Global.enemyCanShoot = false;
			}
		}
	
	}


}
