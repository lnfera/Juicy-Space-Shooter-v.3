using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour
{

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
		
		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;

		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
			
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		print("heh");
		if (other.gameObject.tag == "enemy")
		{
			print("test");
			shakeDuration = 0.6f;
		}
	}
}
