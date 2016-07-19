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
        if (Input.GetKeyDown("up") && col.IsTouchingLayers(8192))
            rb.AddForce(Vector2.up * jump);
        if (Input.GetKey("down") && col.IsTouchingLayers(8192))
            transform.Translate(Vector2.down * Time.deltaTime * movespeed);
        if (Input.GetKey("left"))
            transform.Translate(Vector2.left * Time.deltaTime * movespeed);
        if (Input.GetKey("right"))
            transform.Translate(Vector2.right * Time.deltaTime * movespeed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (other.transform.position.y < rb.position.y - 1)
            {
                rb.AddForce(Vector2.up * jump);
                other.gameObject.SetActive(false);
            }
        }
    }
}
