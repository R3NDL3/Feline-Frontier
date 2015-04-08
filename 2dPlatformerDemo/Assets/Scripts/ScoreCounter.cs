using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {


	public static int coins;
	private Text numCoins;

	public void Start(){
		numCoins = GetComponent<Text> ();
	}

	public void Update(){
		if (coins < 0)
			coins = 0;
		numCoins.text = "" + coins;
	}

	public static void AddCoins (int givenCoins){
		coins += givenCoins;
	}
	public static void reset (){
		coins = 0;
	}
}
