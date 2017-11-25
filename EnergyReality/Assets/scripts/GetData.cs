using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour {

    FortumJson parser;
    int inhabitants;
    int electricityHeatingSurf;

	// Use this for initialization
	void Start () {
        parser = new FortumJson();
        inhabitants = parser.amountofinhabitants;
        electricityHeatingSurf = 20 * 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  

    public float GetYearOutput()
    {
        return electricityHeatingSurf;
    }

    public float GetMonthOutput()
    {
        return electricityHeatingSurf / Random.Range(10, 12);
    }

    public float GetWeekOutput()
    {
        return electricityHeatingSurf / Random.Range(45, 52);
    }

    public float GetDayOutput()
    {
        return electricityHeatingSurf / Random.Range(350, 366);
    }

    public float GetHourOutput()
    {
        return electricityHeatingSurf / Random.Range(8000, 8766);
    }

    public float GetCurrentOutput()
    {
        return Random.Range(90, 250);
    }
}
