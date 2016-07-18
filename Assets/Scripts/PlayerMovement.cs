using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int movespeed = 5;
    public int jump = 0;
    Rigidbody2D rb;
    Collider2D col;
    public GameObject other;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown("up") && col.IsTouchingLayers())
            rb.AddForce(Vector2.up * jump);
        if (Input.GetKey("down") && col.IsTouchingLayers(8192))
            transform.Translate(Vector2.down * Time.deltaTime * movespeed);
        if (Input.GetKey("left") && col.IsTouchingLayers(8192))
            transform.Translate(Vector2.left * Time.deltaTime * movespeed);
        if (Input.GetKey("right")&& col.IsTouchingLayers(8192))
            transform.Translate(Vector2.right * Time.deltaTime * movespeed);
    }
}
