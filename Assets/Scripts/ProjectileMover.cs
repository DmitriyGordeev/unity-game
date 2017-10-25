﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour {

	public ProjectileMover(float vel) {
		velocity = vel;
	}

	public float velocity = 10.0f; 
	public int damage = 10;

	void Start()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (velocity, 0);
	}

	void Update()
	{
	}


	void OnTriggerEnter2D(Collider2D other) {

		if (other.name == "EnemyHard") 
		{
			Destroy (gameObject); 
			SceneGlobals.Global.enemyWasHit = true;
			SceneGlobals.Global.enemyCanShoot = true;
		}
		else if (other.name == "Player") 
		{
			Destroy (gameObject);
			PlayerScript p = (PlayerScript)other.GetComponent<MonoBehaviour>();

			Debug.Log ("Before : p.health = " + p.health);
			p.health -= 10;
			Debug.Log ("After  : p.health = " + p.health);


			GameObject guiObject = other.gameObject.transform.Find ("GuiText").gameObject;
			guiObject.GetComponent<GUIText> ().text = "HP: " + p.health;
		
			SceneGlobals.Global.enemyWasHit = false;
			SceneGlobals.Global.playerCanShoot = true;
		}
	}



}
