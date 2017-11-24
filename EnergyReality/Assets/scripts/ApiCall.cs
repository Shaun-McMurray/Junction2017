using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiCall : MonoBehaviour {

    private string url = "https://fortum.hackjunction.com/api/locations";
    //private string url = "https://requestb.in/12vt9ud1";
    private const string password = "{ \"password\":\"ratkaisutalkootapahtuma\" }";

    public string jsonString;

    IEnumerator Start()
    {
        var encoding = new System.Text.UTF8Encoding();
        var postHeader = new Dictionary<string, string>();

        postHeader.Add("Content-Type", "application/json");

        Debug.Log("password: " + password);

        var request = new WWW(url, encoding.GetBytes(password), postHeader);

        yield return request;

        if (request.text != "")
        {
            jsonString = request.text;
            Debug.Log(request.text);
        }
        else
        {
            string error = request.error;
            Debug.Log(error);
        }
       
    }

}
