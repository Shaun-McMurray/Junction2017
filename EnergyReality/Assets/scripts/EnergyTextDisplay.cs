using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyTextDisplay : MonoBehaviour {
	TextMesh text;
	private int counter;
	public float kWh;
	public string energyData;
	// Use this for initialization
	void Start () {
		text = GetComponent<TextMesh>();
		text.text = energyData;
		Debug.Log(energyData);
	}
	
	// Update is called once per frame
	void Update () {
		//if(counter > 10){
			//kWh = Random.Range(0.0f, 10.0f);
			energyData = "Energy usage: " + kWh + " kWh";
			text.text = energyData;
			Debug.Log(energyData);
			counter = 0;
		//}
		//counter++;
	}
	public void changeKWH(float newGuy){
		kWh = newGuy;

	}
}
