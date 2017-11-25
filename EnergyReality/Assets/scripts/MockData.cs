using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class MockData : MonoBehaviour
{
    string jsonString;

    void Start()
    {
        Generate();
    }
    void Generate()
    {
        Queue<string> q = new Queue<string>();

        for (int year = 0; year <= 5; year++) {
            for (int month = 1; month <= 12; month++) {
                for (int day = 1; day <= 30; day++) {
                    for (int hour = 0; hour <= 23; hour++) {  
                        jsonString = "{\"annual\": {\"year\": " +
                            "\"" + year + "\", " +
                            "\"monthly\": " +
                            "{ \"month\":\"" + month + "\"," +
                            " \"daily\": " +
                            "{ \"day\":\"" + day + "\"," +
                            " \"hourly\": { " +
                            "\"hour\":\"" + hour + "\"}}}}";
                        q.Enqueue(jsonString);
                    }
                }
            }
            
        }

        foreach (var year in q) {
            Debug.Log(year);
        }
    }
}                              