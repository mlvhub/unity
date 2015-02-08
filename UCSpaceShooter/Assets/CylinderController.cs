using UnityEngine;
using System.Collections;

public class CylinderController : MonoBehaviour {

  public VirtualJoystick joystick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    this.rigidbody2D.velocity = joystick.movement;
    //this.rigidbody2D.AddForce(joystick.movement);
	}
}
