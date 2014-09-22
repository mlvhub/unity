using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

	public int hitsToKill;
	public int points;
	private int currentHits;

	public PlayerController player;
	
	// Use this for initialization
	void Start () {
		currentHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		
		if (collision.gameObject.tag == Game.BallTag){
			currentHits++;
			
			if (currentHits == hitsToKill) {
				player.AddPoints(points);
				// destroy the object
				Destroy(this.gameObject);
			}
		}
	}
}
