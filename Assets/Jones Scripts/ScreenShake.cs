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
		
	}

	public void Shake(Transform cam)
	{
		camTransform = cam;
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
}