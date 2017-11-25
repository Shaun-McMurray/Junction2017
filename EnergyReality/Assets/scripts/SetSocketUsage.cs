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

        SetUsage();
	}
	
	// Update is called once per frame
	public void SetUsage () {

        foreach (GameObject socketImage in mySockets)
        {
            SetSocketColour(socketImage, GetComponent<ElectricityUsageDummy>().ElectricalUsagePerYear());
        }
	}

    void SetSocketColour(GameObject imageObject, float number)
    {
        if(number == 1)
        {
            imageObject.GetComponent<Image>().sprite = green;
        }
        else if (number == 2)
        {
            imageObject.GetComponent<Image>().sprite = yellow;
        }
        else if (number == 3)
        {
            imageObject.GetComponent<Image>().sprite = red;
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
