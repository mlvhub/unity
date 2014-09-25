using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	private bool ballIsActive;
	private Vector3 ballPosition;
	private Vector2 ballInitialForce;
	public AudioClip hitSound;

	private PlatformInputHandler inputHandler = InputHandler.PlatformInput;

	// GameObject
	public PlayerController player;

	// Use this for initialization
	void Start () {
		// create the force
		ballInitialForce = new Vector2 (100.0f,300.0f);
		
		// set to inactive
		ballIsActive = false;
		
		// ball position
		ballPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (!ballIsActive && player != null){
			// check for user input
			if (inputHandler.TouchTop()) {
				// check if is the first play
				rigidbody2D.isKinematic = false;
				// add a force
				rigidbody2D.AddForce(ballInitialForce);
				// set ball active
				ballIsActive = !ballIsActive;
			}

			// get and use the player position
			ballPosition.x = player.transform.position.x;
			
			// apply player X position to the ball
			transform.position = ballPosition;
		}

		if (ballIsActive && transform.position.y < -6) {
			rigidbody2D.isKinematic = true;
			ballIsActive = !ballIsActive;
			ballPosition.x = player.transform.position.x;
			ballPosition.y = -4.110506f;
			transform.position = ballPosition;

			player.Die();
		}

	}

	void OnCollisionEnter2D(Collision2D collision){
		if (ballIsActive) {
			audio.PlayOneShot (hitSound);
		}
	}
}
