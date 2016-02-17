using UnityEngine;
using System.Collections;

public class Pickup_Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Respawn()", 0, 10);
	}

    void Respawn()
    {
        if(gameObject.activeSelf == false)
        gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
