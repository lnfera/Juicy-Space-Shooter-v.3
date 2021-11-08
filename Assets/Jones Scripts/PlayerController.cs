using UnityEngine;
using System.Collections;

//skrivet av Jones
public class PlayerController : MonoBehaviour
{
	[SerializeField] //l�gg in i inspektorn
	
	public float speed = 5f; //fart �r 5f

	private Rigidbody2D rb; //variabel 

	void Start()
	{
		rb = GetComponent<Rigidbody2D>(); //h�mta component
	}


	void Update()
	{
		movement();
	//	facingturn();
	}

	void movement()
	{
		if (Input.GetKey("a")) //klicka p� a, r�r p� dig
		{
			rb.MovePosition(rb.position += Vector2.left * speed * Time.deltaTime);
		}
		if (Input.GetKey("d")) //klikca p� d, r�r p� dig
		{
			rb.MovePosition(rb.position += Vector2.right * speed * Time.deltaTime);
		}
		if (Input.GetKey("w")) //klicka p� w, r�r p� dig
		{
			rb.MovePosition(rb.position += Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey("s")) //klicka p� s, r�r p� dig
		{
			rb.MovePosition(rb.position += Vector2.down * speed * Time.deltaTime);
		}
	}
}

/*
	void facingturn ()
	{
		//Aim player at mouse
		//which direction is up
		Vector3 upAxis = new Vector3(0, 0, 1);
		Vector3 mouseScreenPosition = Input.mousePosition;
		//set mouses z to your targets
		mouseScreenPosition.z = transform.position.z;
		Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
		transform.LookAt(mouseWorldSpace, upAxis);
		//zero out all rotations except the axis I want
		transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
	}
}
*/