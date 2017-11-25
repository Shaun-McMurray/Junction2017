using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseComparison : MonoBehaviour {

	public GameObject panel;
	// Use this for initialization
	void Start () {
		Button click = GetComponent<Button>();
		click.onClick.AddListener(OnClick);
	}
	
	void OnClick () {
		Destroy(gameObject);
	}
}
