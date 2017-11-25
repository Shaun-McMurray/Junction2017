using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void LoadMyHouse()
    {
        SceneManager.LoadScene("myHouse");
    }

    public void LoadMainScreen()
    {
        SceneManager.LoadScene("TestAR");

    }
}
