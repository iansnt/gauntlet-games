using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int movespeed = 5;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey("up"))
            transform.Translate(Vector2.up * Time.deltaTime * movespeed);
        if (Input.GetKey("down"))
            transform.Translate(Vector2.down * Time.deltaTime * movespeed);
        if (Input.GetKey("left"))
            transform.Translate(Vector2.left * Time.deltaTime * movespeed);
        if (Input.GetKey("right"))
            transform.Translate(Vector2.right * Time.deltaTime * movespeed);
    }
}
