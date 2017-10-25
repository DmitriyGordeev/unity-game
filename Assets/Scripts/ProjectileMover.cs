using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour {

	public ProjectileMover(float vel, float damage) {
		velocity = vel;
		this.damage = damage;
	}

	public float velocity;
	public float damage;

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
			PlayerScript p = other.gameObject.GetComponent<PlayerScript> ();
			p.health -= damage;

			GameObject guiObject = other.gameObject.transform.Find ("GuiText").gameObject;
			guiObject.GetComponent<GUIText> ().text = "HP: " + p.health;
		
			SceneGlobals.Global.enemyWasHit = false;
			SceneGlobals.Global.playerCanShoot = true;
		}
	}



}
