using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public ProjectileMover shot;
	public Transform shotSpawn;
	public float health;
    public GameObject dialogObject;


	private bool firstSelected = true;

	// Update is called once per frame
	void Start() {
		dialogObject.GetComponent<GUIText> ().richText = true;
	}


	void Update () {

		if (Input.GetKey (KeyCode.Mouse0)) {
			if (SceneGlobals.Global.playerCanShoot) {

				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
				shot.damage = 10;
				shot.velocity = 7;

				SceneGlobals.Global.playerCanShoot = false;
			}

		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {

			if (firstSelected) {
				dialogObject.GetComponent<GUIText> ().text = "Attack A\n<color=#0080f0ff>Attack B</color>";
				firstSelected = false;
			}
			else {
				dialogObject.GetComponent<GUIText> ().text = "<color=#0080f0ff>Attack A</color>\nAttack B";
				firstSelected = true;
			}

		}
	}


}
