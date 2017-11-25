using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyHouse : MonoBehaviour
{

    public Button myHouseButton;
	public Button mapbutton;
    public GameObject floorPlan;
    public GameObject lightPanel;


    // Use this for initialization
    void Start()
    {
        Button btn = myHouseButton.GetComponent<Button>();
        TaskOnClick(false);
    }

    public void TaskOnClick(bool boolVal)
    {
        floorPlan.SetActive(boolVal);

        Debug.Log(boolVal);
        for(int i = 0; i < lightPanel.transform.childCount; i++)
        {
            lightPanel.transform.GetChild(i).gameObject.SetActive(boolVal);
        }
		mapbutton.gameObject.SetActive(boolVal);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
