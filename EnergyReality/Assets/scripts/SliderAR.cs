using UnityEngine;
using UnityEngine.UI;


public class SliderAR : MonoBehaviour {

    Text textSlider;

    GetData data;

    float output;


    // Use this for initialization
    void Start () {
        data = GetComponentInParent<GetData>();

        textSlider = GetComponentInChildren<Text>();
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
    }

    public void SetSliderValue(float sliderValue)
    {
        if (sliderValue <= 0)
        {
			output = Mathf.Round(data.GetCurrentOutput()); 
            textSlider.text = "Current Electrical Output " + output + " watts";
        }
        else if (sliderValue <= 1)
        {
			output = Mathf.Round((data.GetHourOutput() * 10) / 15); 
            textSlider.text = "Electrical Output per Hour " + output + " watts";
        } else if (sliderValue <= 2)
        {
			output = Mathf.Round((data.GetDayOutput() * 5 )/ 15); 
            textSlider.text = "Electrical Output per Day " + output + " watts";

        }
        else if (sliderValue <= 3)
        {
			output = Mathf.Round(data.GetWeekOutput() / 15); 
            textSlider.text = "Electrical Output per Week " + output + " watts";

        }
        else if (sliderValue <= 4)
        {
			output = Mathf.Round(data.GetMonthOutput() / 15); 
            textSlider.text = "Electrical Output per Month " + output + " watts";
        }
        else if(sliderValue > 4)
        {
			output = Mathf.Round(data.GetYearOutput() / 15); 
            textSlider.text = "Electrical Output per Year " + output + " watts";
        }
    }
}
