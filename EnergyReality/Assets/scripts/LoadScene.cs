using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    private Button loadButton;
    public string scene; // Add the name of the scene. Script attached to buttons. Update build settings.
	// Use this for initialization
	void Start () {
        loadButton = GetComponent<Button>();
        loadButton.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void OnClick () {
        SceneManager.LoadScene(scene);
	}
}
