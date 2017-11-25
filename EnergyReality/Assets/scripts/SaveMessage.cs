using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveMessage : MonoBehaviour {

	public GameObject buttonParent;
	Text inputMessage;

	StoreData messageData;

	// Use this for initialization
	void Start () {
		messageData = new StoreData ();
		//inputMessage = messagePanel.GetComponentInChildren<Text>();
		StoreData.messages = ""; // Removing "new text" on startup

		var input = gameObject.GetComponent<InputField>();

		input.onEndEdit.AddListener(GetInputText);  

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GetInputText(string messageText){
		//inputMessage.text += messageText + "\n";
		Debug.Log (messageText);
		StoreData.messages += messageText + "\n";
	}
		
}
