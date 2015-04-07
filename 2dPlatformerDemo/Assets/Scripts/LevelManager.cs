using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public GameObject respawnPoint;
	
	private PlayerBehavior player;
	
	// Use this for initialization
	public void Start () {
		player = FindObjectOfType<PlayerBehavior> ();
	}
	
	public void RespawnPlayer(){
		Debug.Log ("Player Respawned");
		player.transform.position = respawnPoint.transform.position;
	}
}
