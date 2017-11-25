using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class MockData : MonoBehaviour
{
    string jsonString;

    void Start()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        Queue<string> q = new Queue<string>();

        for (int year = 2012; year <= 2017; year++) {
            for (int month = 1; month <= 12; month++) {
                for (int day = 1; day <= 30; day++) {
                    for (int hour = 0; hour <= 23; hour++) {  
                        jsonString = "\"annual\": {\"year\": " +
                            "\"" + year + "\", " +
                            "\"monthly\": " +
                            "{ \"month\":\"" + month + "\"," +
                            " \"daily\": " +
                            "{ \"day\":\"" + day + "\"," +
                            " \"hourly\": { " +
                            "\"hour\":\"" + hour + "\"}}},";
                        q.Enqueue(jsonString);
                    }
                }
            }
            
        }

        var encoding = new System.Text.UTF8Encoding();

        UnityWebRequest start = UnityWebRequest.Put("https://33b5d6ea-ce4c-41fd-81a6-484d3dd2129e.mock.pstmn.io/arlecticity", encoding.GetBytes("{"));
        yield return start.SendWebRequest();


        foreach (var year in q) {
            UnityWebRequest wb = UnityWebRequest.Put("https://33b5d6ea-ce4c-41fd-81a6-484d3dd2129e.mock.pstmn.io/arlecticity", encoding.GetBytes(year));
            yield return wb.SendWebRequest();

            if (wb.isNetworkError || wb.isHttpError)
            {
                Debug.Log(wb.error);
            }
            else
            {
                Debug.Log("Upload complete!");
            }
        }

        UnityWebRequest end = UnityWebRequest.Put("https://33b5d6ea-ce4c-41fd-81a6-484d3dd2129e.mock.pstmn.io/arlecticity", encoding.GetBytes("}"));
        yield return end.SendWebRequest();
    }
}                              