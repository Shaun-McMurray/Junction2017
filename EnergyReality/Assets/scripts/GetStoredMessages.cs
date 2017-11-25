using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStoredMessages : MonoBehaviour {
	StoreData messageData;

	// Use this for initialization
	void Start () {
		messageData = new StoreData();
		Debug.Log ("Data " + StoreData.messages);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponentInChildren<Text> ().text = StoreData.messages;
		//Debug.Log ("hakuna matata " + );
	}
}
