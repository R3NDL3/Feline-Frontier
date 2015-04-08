using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int coinValue;

	public void OnTriggerEnter2D (Collider2D coll){
		if (coll.GetComponent<PlayerBehavior> () == null)
			return;
		ScoreCounter.AddCoins(coinValue);
		Destroy (gameObject);
	}
}
