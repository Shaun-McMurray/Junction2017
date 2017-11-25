using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour {

	public Color color;
	//public Button image;
	public Button yourButton;
	// Use this for initialization
	void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Button btn = yourButton.GetComponent<Button>();
     
        color.r = 1; 
        color.g = 0.1f; 
        color.b = 0.1f; 
        color.a = 0.5f; 
     
        ColorBlock cb = yourButton.colors;
        cb.normalColor = color;
        yourButton.colors = cb;
		Debug.Log("button clicked");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
