using UnityEngine;
using System.Collections;

public class DestroyFinishedParticle : MonoBehaviour {
	private ParticleSystem thisParticleSystem;
	public void Start(){
		thisParticleSystem = GetComponent<ParticleSystem> ();
	}
	public void Update () {
	if (thisParticleSystem.isStopped)
			Destroy (gameObject);
	}
}
