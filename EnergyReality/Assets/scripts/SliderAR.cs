using UnityEngine;
using UnityEngine.UI;


public class SliderAR : MonoBehaviour {

    Text textSlider;

    GetData data;

    float output;
    float indvidual;

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
            indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;
        }
        else if (sliderValue <= 1)
        {
			output = Mathf.Round((data.GetHourOutput() * 10) / 15); 
            indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;
        } else if (sliderValue <= 2)
        {
			output = Mathf.Round((data.GetDayOutput() * 5 )/ 15); 
           indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;

        }
        else if (sliderValue <= 3)
        {
			output = Mathf.Round(data.GetWeekOutput() / 15); 
            indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;

        }
        else if (sliderValue <= 4)
        {
			output = Mathf.Round(data.GetMonthOutput() / 15); 
            indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;
        }
        else if(sliderValue > 4)
        {
			output = Mathf.Round(data.GetYearOutput() / 15); 
            indvidual = output / 5;
            textSlider.text = "Current Electrical Use: " + output + " watts" + "\n"
            + "Individual Use: " + indvidual;
        }
    }
}
