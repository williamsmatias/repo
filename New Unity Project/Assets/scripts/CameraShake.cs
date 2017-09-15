using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	
	// How long the object should shake for.
	public float shakeDuration = 35.0f;
	
	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.2f;
	public float decreaseFactor = 1.0f; //time to decrease shake duration
	public float timeToShake = 6.0f; //time to start shake

	Vector3 originalPos;
	
	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void OnEnable()
	{

		originalPos = camTransform.localPosition;
	}

	void Update()
	{
		if (timeToShake > 0) {

			timeToShake = timeToShake - Time.deltaTime * 1.0f;//decrease in one sec the time to start shake
		}

		if (shakeDuration > 0 && timeToShake < 0) 
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			//shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}
}
