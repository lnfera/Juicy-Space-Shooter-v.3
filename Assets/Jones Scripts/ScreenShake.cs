using UnityEngine;
using System.Collections;

//skrivet av Jones
public class ScreenShake : MonoBehaviour
{
	//variabler 
	public Transform camTransform; 

	public float shakeDuration = 0f;  // Variabel, hur länge objektet ska skaka. 

	public float shakeAmount = 0.7f;  // Amplitude av skakningen. Högre värde får objektet att skaka hårdare
	
	public float decreaseFactor = 1.0f;  // Sänker skakningen så att den inte ska bli för stor


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
		
		if (shakeDuration > 0) //shakeduration är större än 0 
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;  

			shakeDuration -= Time.deltaTime * decreaseFactor;

		}
		else
		{
			shakeDuration = 0f; //shakeduration är 0
			camTransform.localPosition = originalPos; //gå tillbaka till den normala positionen 
			
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		print("heh");
		if (other.gameObject.tag == "enemy") // om den kolliderar med enemies 
		{
			print("test");
			shakeDuration = 0.6f; //shakeduration är 0,6f 
		}
	}
}
