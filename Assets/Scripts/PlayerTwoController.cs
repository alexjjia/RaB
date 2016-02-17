using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //used in the Pause menu

public class PlayerTwoController : MonoBehaviour
//Essentially this is identical to the Player2Controller.cs, but I gave it the same controls as PlayerController.cs uses. This is because I used the player scripts to implement the pause menus.
//So think of this script as a PlayerController.cs script, except specific for the first player in the 2player game system.
{

    public float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    private int count = 0;
    // Use this for initialization
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

        //jumping code.
        if (Input.GetKeyDown("f") && GetComponent<Rigidbody>().transform.position.y <= 0.6250001f)
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);
        }
        //pause menu
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("PauseTwoMenu");
        }
        if (GetComponent<Rigidbody>().transform.position.y < 0)
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            winningTerms();
        }
        else if (other.gameObject.tag == "Wall")
        {
            count -= 1;
        }
    }
    void winningTerms()
    {
        scoreText.text = "Score: " + count;
        if (count >= 10)
        {
            winText.text = "Player 1 Wins!";
            winText.gameObject.SetActive(true);
        }
    }
}

