using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	public void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	public void Update () {
	
	}

	public void OnTriggerEnter2D( Collider2D coll ){
		if (coll.name == "Player") {
			levelManager.RespawnPlayer ();
		}
	}
}
