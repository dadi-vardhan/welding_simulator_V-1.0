using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welding_torch: MonoBehaviour {
	private GameObject instant_1;

	// Use this for initialization
	void Start () {
		LoadfromData ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadfromData(){
		GameObject terrain1 = Resources.Load ("prefab_arc") as GameObject;

		instant_1 = Instantiate (terrain1);

	}


}

