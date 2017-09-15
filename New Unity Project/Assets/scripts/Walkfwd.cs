
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Walkfwd : MonoBehaviour 
{
	private CharacterController controller;
	//cardboard script
	private Cardboard cardboard;
	//vr head
	private Transform vrHead;
	// This variable determinates if the player will move or not 
	private bool isWalking = false;
	//This is the variable for the player speed
	[Tooltip("With this speed the player will move.")]
	public float speed;
	
	void Start () 
	{
		//find the character controller
		controller = GetComponent<CharacterController>();
		//find the cardboard in the child 0
		cardboard = transform.GetChild(0).GetComponent<Cardboard>();
		vrHead = Camera.main.transform;
	}
	
	void Update () 
	{
		// Walk when the Cardboard Trigger is used 
		if (Cardboard.SDK.Triggered) 
		{
			isWalking = !isWalking;
		} 

		if (isWalking) 
		{
			//find te forward direction
			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			//charactercontroller move forward
			controller.SimpleMove (forward * speed);
		}
	}
}