using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideMap : MonoBehaviour
{

    public Button mapButton;
    public GameObject floorPlan;
    public GameObject lightPanel;

    bool mapActive = true;

    // Use this for initialization
    void Start()
    {
        Button btn = mapButton.GetComponent<Button>();
        //mapActive = false;
        TaskOnClick();
    }

    public void TaskOnClick()
    {
        mapActive = !mapActive;
        floorPlan.SetActive(mapActive);

        Debug.Log(mapActive);
        for(int i = 0; i < lightPanel.transform.childCount; i++)
        {
            lightPanel.transform.GetChild(i).gameObject.SetActive(mapActive);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
