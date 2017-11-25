using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class Comparison : MonoBehaviour
{

    private string url = "https://api.priceapi.com/jobs";

    public string value = "";

    void Start ()
    {

        StartCoroutine(Request());

    }

    IEnumerator Request() {

        WWWForm form = new WWWForm();
        form.AddField("token", "WMQCDXPTUOIRARBSGPMQTLANXXRDRUDBXBXBUZOMGGBTDVBCMBBFYZXFAPCHTJXT");
        form.AddField("country", "se");
        form.AddField("source", "google-shopping");
        form.AddField("currentness", "daily_updated");
        form.AddField("completeness", "one_page");
        form.AddField("key", "keyword");
        form.AddField("values", value);

        if (value != "")
        {
            WWW request = new WWW(url, form);

            yield return request;

            Debug.Log("Request: " + request.text);
        
            WWW check = new WWW("https://api.priceapi.com/jobs/" +
                "5a196fb15fc8fc3c4b23435f?" +
                "token=WMQCDXPTUOIRARBSGPMQTLANXXRDRUDBXBXBUZOMGGBTDVBCMBBFYZXFAPCHTJXT");

            yield return check;

            if (check.text.Contains("finished"))
            {

                WWW result = new WWW("https://api.priceapi.com/products/bulk/" +
                    "5a196fb15fc8fc3c4b23435f?token=WMQCDXPTUOIRARBSGPMQTLANXXRDRUDBXBXBUZOMGGBTDVBCMBBFYZXFAPCHTJXT");

                yield return result;
                Debug.Log("Result: " + result.text);

            }
            else
            {
                yield return check;
            }


        }
    }
}
