using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class How2PlayScript : MonoBehaviour {
    private int buttonWidth = 200;
    private int buttonHeight = 50;

    void OnGUI()
    {
        Rect backbutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2) + 3 * buttonHeight, buttonWidth, buttonHeight);
        if (GUI.Button(backbutton, "Back"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
