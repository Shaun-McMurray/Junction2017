﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScanMode : MonoBehaviour
{

    public Button scanButton;
    public GameObject field1;
    public GameObject field2;
    public Image image;

    bool mapActive = true;

    // Use this for initialization
    void Start()
    {
        image.gameObject.SetActive(false); 
        Button btn = scanButton.GetComponent<Button>();
        //mapActive = false;
    }

    public void TaskOnClick()
    {
        image.gameObject.SetActive(true);
        mapActive = !mapActive;
        field1.SetActive(mapActive);
        field2.SetActive(mapActive);

        scanButton.gameObject.SetActive(mapActive);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
