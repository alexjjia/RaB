using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private int buttonWidth = 200;
    private int buttonHeight = 50;

    void OnGUI()
    {
        Rect menubutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2) - (3 / 2) * buttonWidth, (2 * Screen.height / 3) - (buttonHeight / 2) + 3 * buttonHeight, buttonWidth, buttonHeight);
        Rect quitbutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2) + (3 / 2) * buttonWidth, (2 * Screen.height / 3) - (buttonHeight / 2) + 3 * buttonHeight, buttonWidth, buttonHeight);

        if (GUI.Button(quitbutton, "Quit"))
        {
            Application.Quit();
        }
        else if (GUI.Button(menubutton, "Back to Menu"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
