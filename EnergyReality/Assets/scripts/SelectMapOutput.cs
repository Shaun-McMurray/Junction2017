using UnityEngine;
using UnityEngine.UI;


public class SelectMapOutput : MonoBehaviour {

    Text textSlider;
    SetSocketUsage randomizeSockets;

	// Use this for initialization
	void Start () {
        textSlider = GetComponentInChildren<Text>();
        randomizeSockets = GetComponentInParent<SetSocketUsage>();
    }


    public void SetSliderValue(float sliderValue)
    {
        if(sliderValue <= 1)
        {
            textSlider.text = "Electrical Output per Day";
        } else if (sliderValue <= 2)
        {
            textSlider.text = "Electrical Output per Week";

        }
        else if (sliderValue <= 3)
        {
            textSlider.text = "Electrical Output per Month";

        }
        else if (sliderValue <= 4)
        {
            textSlider.text = "Electrical Output per Year";
        }
        else if(sliderValue > 4)
        {
            textSlider.text = "Electrical Output per 5 Years";
        }
    }

    public void SetElectricalUsage(float sliderValue)
    {
        if (sliderValue == 1)
        {
            randomizeSockets.SetUsage();
        }
        else if (sliderValue == 2)
        {
            randomizeSockets.SetUsage();

        }
        else if (sliderValue == 3)
        {
            randomizeSockets.SetUsage();

        }
        else if (sliderValue == 4)
        {
            randomizeSockets.SetUsage();

        }
        else if (sliderValue == 5)
        {
            randomizeSockets.SetUsage();
        }
    }
}
