using UnityEngine;
using System.Collections;
/// <summary>
/// This script controls movement of ball
/// </summary>
public class BallMove : MonoBehaviour {
	//speed at which ball moves
	 public int speed;
	//speed at which ball bounces
	public int BounceSpeed;

	GameController speedController;
	void Start(){
		//getting value of speed and BounceSpeed from the GameController
		GameObject go = GameObject.Find ("GameController");
		speedController = go.GetComponent <GameController> ();
		speed = speedController.speed;
		BounceSpeed = speedController.BounceSpeed;
	}
	// Update is called once according to physics
	void FixedUpdate ()
	{
		//speed = speedController.speed;
		//BounceSpeed = speedController.BounceSpeed;
		//moving the ball
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,speed);
	}

	void BounceStart(){
		//after bouncing from racket ball bounces in opposite direction
		speed = BounceSpeed;
	}
}