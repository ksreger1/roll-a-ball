using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	public float speed;
	public Text countText;
	public Text victoryText;
	
	private Rigidbody _rb;	
	private int _count;

	// Use this for initialization
	void Start () 
	{
		_rb = GetComponent<Rigidbody>();
		_count = 0;
		SetCountText();
		victoryText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float horizontalMovement = Input.GetAxis ("Horizontal");
		float verticalMovement = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
		_rb.AddForce(movement * speed);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Coin"))
		{
			other.gameObject.SetActive(false);
			_count++;
			SetCountText();
		}
	}
	
	void SetCountText()
	{
		countText.text = string.Format("Count: {0}", _count.ToString());
		
		if(_count >= 12)
		{
			victoryText.text = "You win!";
		}
	}
}
