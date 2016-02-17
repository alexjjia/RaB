using UnityEngine;
using UnityEngine.SceneManagement;

class Timer : MonoBehaviour
{
    float timeLeft = 120.0f; //its 5 min = 300 sec
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
       SceneManager.LoadScene("GameOver");
    }
}
