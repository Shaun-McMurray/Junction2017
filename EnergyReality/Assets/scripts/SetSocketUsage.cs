using UnityEngine;
using UnityEngine.UI;

public class SetSocketUsage : MonoBehaviour {

    public Sprite green;
    public Sprite yellow;
    public Sprite red;

    private GameObject[] mySockets;
    private float spriteNumber;

    // Use this for initialization
    void Start () {
        mySockets = GameObject.FindGameObjectsWithTag("Socket");

        SetUsage(spriteNumber);
	}
	
	// Update is called once per frame
	void SetUsage (float number) {
        foreach (GameObject socketImage in mySockets)
        {
            SetSocketColour(socketImage, GetComponent<ElectricityUsageDummy>().ElectricalUsagePerYear());
        }
	}

    void SetSocketColour(GameObject imageObject, float number)
    {
        if(number == 1)
        {
            SetSocketGood(imageObject.GetComponent<Image>());
        }
        else if (number == 2)
        {
            SetSocketOk(imageObject.GetComponent<Image>());
        }
        else if (number == 3)
        {
            SetSocketBad(imageObject.GetComponent<Image>());
        }
        else
        {
            Debug.Log("Could not get Electrical output");
        }
    }

    void SetSocketGood(Image socketImage)
    {
        socketImage.sprite = green;
    }

    void SetSocketOk(Image socketImage)
    {
        socketImage.sprite = yellow;
    }

    void SetSocketBad(Image socketImage)
    {
        socketImage.sprite = red;
    }
}
