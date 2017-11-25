using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderCompareCanvas : MonoBehaviour {

    private Button compare;
    private GameObject compareCanvasPrefab;

    private Transform parent;
	// Use this for initialization
	void Start () {
        compare = GetComponent<Button>();
        compare.onClick.AddListener(OnClick);
        
        compareCanvasPrefab = GameObject.Find("ComparisonCanvas");
	}

    void OnClick()
    {
        parent = compare.GetComponentInParent<Transform>();

        GameObject compareCanvas = Instantiate (compareCanvasPrefab);
        compareCanvas.transform.SetParent(parent);
    }
}
