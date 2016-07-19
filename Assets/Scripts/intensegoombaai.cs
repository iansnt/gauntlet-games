using UnityEngine;
using System.Collections;

public class intensegoombaai : MonoBehaviour {
    private bool movingRight;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        movingRight = false;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (movingRight)
            transform.Translate(Vector3.right * 3 * Time.deltaTime);
        else
            transform.Translate(Vector3.left * 3 * Time.deltaTime);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            if (!movingRight)
            {
                if (rb.position.x < other.gameObject.transform.position.x - other.collider.bounds.extents.x)
                    movingRight = true;
            }
            else if (rb.position.x > other.gameObject.transform.position.x + other.collider.bounds.extents.x)
                movingRight = false;
        }
    }
}
