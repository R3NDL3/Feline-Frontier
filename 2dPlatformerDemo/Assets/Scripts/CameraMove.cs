using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	private Vector2 viewPos;
	private PlayerBehavior player;
	
	// Use this for initialization
	public void Start () {
		player = FindObjectOfType<PlayerBehavior> ();
	}

	void Update () {
		viewPos = new Vector2 (player.transform.position.x, 0);
		Camera.main.transform.position = viewPos;
	}
}
