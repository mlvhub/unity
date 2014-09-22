using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PlayerController))]
public class PlayerController : MonoBehaviour {

	public float playerVelocity;
	private Vector3 playerPosition;
	public float boundary;

	private int lives;
	private int points;

	public AudioClip dieSound;
	public AudioClip pointSound;

	// Use this for initialization
	void Start () {
		playerPosition = gameObject.transform.position;
		
		this.lives = 3;
		this.points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// horizontal movement
		playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity;
		
		// leave the game
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
		
		// boundaries
		if (playerPosition.x < -boundary) {
			playerPosition.x = -boundary;
		} 
		if (playerPosition.x > boundary) {
			playerPosition.x = boundary; 
		}
		
		// update the game object transform
		transform.position = playerPosition;

		// Check game state
		WinLose ();
	}

	void OnGUI(){
		GUI.Label (new Rect(5.0f,3.0f,200.0f,200.0f),"Live's: " + this.lives + "  Score: " + this.points);
	}
	
	public void AddPoints(int points) {
		this.points += points;
		audio.PlayOneShot(pointSound);
	}

	public void Die() {
		this.lives--;
		audio.PlayOneShot(dieSound);
	}

	void WinLose(){
		// restart the game
		if (this.lives == 0) {
			Application.LoadLevel("Level1");        
		}
		// blocks destroyed
		if ((GameObject.FindGameObjectsWithTag ("Block")).Length == 0) {
			// check the current level
			if (Application.loadedLevelName == "Level1") {
				Application.LoadLevel("Level2");
			} else {
				Application.Quit();
			}
		}
	}
}
