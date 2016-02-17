using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //used in the Pause menu

public class Player2Controller : MonoBehaviour {

    public float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    private int count = 0;
	// Use this for initialization
	void Start () {
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

        //jumping code.
        if (Input.GetKeyDown("/") && GetComponent<Rigidbody>().transform.position.y <= 0.6250001f)
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);
        }
        //pause menu
        if(Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("PauseTwoMenu");
        }
        if(GetComponent<Rigidbody>().transform.position.y < 0)
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
        else if(other.gameObject.tag == "Wall")
        {
            count -= 1;
        }
    }
    void winningTerms()
    {
        scoreText.text = "Score: " + count;
        if (count >= 10)
        {
            winText.text = "Player 2 Wins!";
            winText.gameObject.SetActive(true);
        }
    }
}
