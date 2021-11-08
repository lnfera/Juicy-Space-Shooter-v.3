using UnityEngine;
using System.Collections;

//skrivet av Jones
public class ScreenShake : MonoBehaviour
{
	//variabler 
	public Transform camTransform; 

	public float shakeDuration = 0f;  // Variabel, hur l�nge objektet ska skaka. 

	public float shakeAmount = 0.7f;  // Amplitude av skakningen. H�gre v�rde f�r objektet att skaka h�rdare
	
	public float decreaseFactor = 1.0f;  // S�nker skakningen s� att den inte ska bli f�r stor


	Vector3 originalPos; 
	void Awake()
	{

	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition; 
	}

	void Update()
	{
		
		if (shakeDuration > 0) //shakeduration �r st�rre �n 0 
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;  

			shakeDuration -= Time.deltaTime * decreaseFactor;

		}
		else
		{
			shakeDuration = 0f; //shakeduration �r 0
			camTransform.localPosition = originalPos; //g� tillbaka till den normala positionen 
			
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		print("heh");
		if (other.gameObject.tag == "enemy") // om den kolliderar med enemies 
		{
			print("test");
			shakeDuration = 0.6f; //shakeduration �r 0,6f 
		}
	}
}
