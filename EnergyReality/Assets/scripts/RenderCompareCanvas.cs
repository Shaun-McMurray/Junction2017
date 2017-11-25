using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderCompareCanvas : MonoBehaviour {

    private Button compare;
    private GameObject comparePanelPrefab;

    private Transform parent;
	// Use this for initialization
	void Start () {
        compare = GetComponent<Button>();
        compare.onClick.AddListener(OnClick);
        
        comparePanelPrefab = GameObject.Find("ComparisonPanel");
	}

    void OnClick()
    {
        parent = compare.GetComponentInParent<Transform>();

        GameObject comparePanel = Instantiate (comparePanelPrefab);
        comparePanel.transform.SetParent(parent, false);
        comparePanel.GetComponent<RectTransform>()
            .transform.localPosition = new Vector3 (-570, -800, 0);
    }
}
