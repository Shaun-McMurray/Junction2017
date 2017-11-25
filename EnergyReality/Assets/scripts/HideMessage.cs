using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideMessage : MonoBehaviour
{

    public Button lightButton;
    public GameObject messagePanel;

    bool messageActive = true;

    // Use this for initialization
    void Start()
    {
        Button btn = lightButton.GetComponent<Button>();
        //messageActive = false;
        TaskOnClick();
    }

    public void TaskOnClick()
    {
        messageActive = !messageActive;
        messagePanel.SetActive(messageActive);
        for (int i = 0; i < messagePanel.transform.childCount; i++)
        {
            messagePanel.transform.GetChild(i).gameObject.SetActive(messageActive);
        }
    }

}
