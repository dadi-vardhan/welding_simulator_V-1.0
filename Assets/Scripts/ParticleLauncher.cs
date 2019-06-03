using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour {

	public ParticleSystem particleLauncher;

	void Update () 
	{
		if (Input.GetButton ("Fire1")) 
			particleLauncher.Emit (10);
	}

}