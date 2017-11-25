using UnityEngine;
using UnityEngine.UI;


public class SelectMapOutput : MonoBehaviour {

    Text textSlider;
    SetSocketUsage randomizeSockets;

    private GameObject[] mySockets;
    GetData data;

    float output;
  
    public Sprite green;
    public Sprite yellow;
    public Sprite red;

    // Use this for initialization
    void Start () {
        data = GetComponentInParent<GetData>();

        mySockets = GameObject.FindGameObjectsWithTag("Socket");
        Debug.Log(mySockets.Length);

        textSlider = GetComponentInChildren<Text>();
        randomizeSockets = GetComponentInParent<SetSocketUsage>();
    }

    public void SetOutputSlider(float sliderPosition)
    {
        if (sliderPosition == 0)
        {
            output = data.GetCurrentOutput();
        }
        else if (sliderPosition == 1)
        {
            output = data.GetDayOutput();
        }
        else if (sliderPosition == 2)
        {
            output = data.GetWeekOutput();
        }
        else if (sliderPosition == 3)
        {
            output = data.GetMonthOutput();
        }
        else
        {
            output = data.GetYearOutput();
        }

        float outputPerSocket = output / mySockets.Length;

        foreach (GameObject socket in mySockets)
        {
            float socketValue = Random.Range(outputPerSocket * 0.5f, outputPerSocket * 1.5f);
            float deviation = (outputPerSocket * 0.25f); 
            output = output - Random.Range(outputPerSocket * 0.5f, outputPerSocket * 1.5f);
            Debug.Log(socket.transform);
            if (socketValue >= (outputPerSocket + deviation))
            {
                socket.GetComponent<Image>().sprite = red;
            }
            else if (socketValue >= (outputPerSocket - deviation))
            {
                socket.GetComponent<Image>().sprite = yellow;
            }
            else
            {
                socket.GetComponent<Image>().sprite = green;
            }
        }
    }

    public void SetSliderValue(float sliderValue)
    {
        if (sliderValue <= 0)
        {
            textSlider.text = "Current Electrical Output";
        }
        else if (sliderValue <= 1)
        {
            textSlider.text = "Electrical Output per Hour";
        } else if (sliderValue <= 2)
        {
            textSlider.text = "Electrical Output per Day";

        }
        else if (sliderValue <= 3)
        {
            textSlider.text = "Electrical Output per Week";

        }
        else if (sliderValue <= 4)
        {
            textSlider.text = "Electrical Output per Month";
        }
        else if(sliderValue > 4)
        {
            textSlider.text = "Electrical Output per Year";
        }
    }
}
