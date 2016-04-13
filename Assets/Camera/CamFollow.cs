using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {



	//to move camera
	public Transform target;
	//add some natural motion
	public float smoothing = 5f;



	//creates a variable to determine distance from cam to player
	Vector3 offset;

	//defines distance from camera to player
	void Start()
	{
		offset = transform.position - target.position;
	}


	void FixedUpdate()
	{
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
 
}
