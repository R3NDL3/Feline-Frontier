using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	private PlayerBehavior player;
	private Vector3 viewPos;
	

	public void Start () {
		player = FindObjectOfType<PlayerBehavior> ();
	}


	public void Update () {
		viewPos = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
		transform.position = viewPos;
	}
}
