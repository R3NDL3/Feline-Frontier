using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public GameObject respawnPoint;
	public float respawnDelay;
	public GameObject deathParticle;
	public GameObject spawnParticle;

	private PlayerBehavior player;

	
	public void Start () {
		player = FindObjectOfType<PlayerBehavior>();
	}

	public void Update () {

	}
	
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Instantiate; Creates an instant of a gameobject
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		player.enabled = false;
		//player.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
		player.GetComponent<Renderer> ().enabled = false;
		yield return new WaitForSeconds (respawnDelay);
		player.transform.position = respawnPoint.transform.position;
		Instantiate (spawnParticle, player.transform.position, player.transform.rotation);
		player.enabled = true;
		player.GetComponent<Renderer> ().enabled = true;
	}

}
