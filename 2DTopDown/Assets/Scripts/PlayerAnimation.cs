using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAnimation : PlayerKeyDelegation {

	private Animator anim;

	private Dictionary<KeyCode, string> directions;

	void Start ()
	{
		base.Start();
		
		anim = GetComponent<Animator>();
		
		directions = new Dictionary<KeyCode, string>();
		directions.Add(KeyCode.W, "Up");
		directions.Add(KeyCode.A, "Left");
		directions.Add(KeyCode.S, "Down");
		directions.Add(KeyCode.D, "Right");
	}

	public void SetDirection(KeyCode direction) {
		foreach (var dir in directions) {
			anim.SetBool(dir.Value, direction == dir.Key);

		}
	}

	void Update() {
		base.Update();
		foreach (var dir in directions) {
			anim.SetBool("Walk"+dir.Value, keyTracker.IsLastKeyPressed(dir.Key));
		}
	}

	#region implemented abstract members of KeyDelegation
	public override void KeyPressed (KeyCode key)
	{
		SetDirection(key);
	}
	#endregion


}
