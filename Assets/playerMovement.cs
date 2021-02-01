using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	Rigidbody2D Rb;
	public float ms;
	public float jf;
	// Use this for initialization
	void Start () {
		Rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		float horiz = Input.GetAxisRaw("Horizontal"); //A,D movement
		Rb.velocity = new Vector2(ms *horiz,Rb.velocity.y);
		if(Input.GetButtonDown("Jump"))
		{
			Rb.AddForce(new Vector2(0,jf));
		}
	}
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Finish"))
			{
				Destroy(gameObject);
			}
			if(other.CompareTag("Respawn"))
			{
				Destroy(gameObject);
			}
			if(other.CompareTag("Coins"))
			{
				Destroy(other.gameObject);
			}
	}
}
