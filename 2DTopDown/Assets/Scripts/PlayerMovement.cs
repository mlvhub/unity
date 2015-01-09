using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : PlayerKeyDelegation {

	public float speed;

	void Start ()
	{
		base.Start();
		
		translationByKeyCode = new Dictionary<KeyCode, Vector3>();
		translationByKeyCode.Add(KeyCode.W, Vector2.up * speed);
		translationByKeyCode.Add(KeyCode.A, Vector2.right * -speed);
		translationByKeyCode.Add(KeyCode.S, Vector2.up * -speed);
		translationByKeyCode.Add(KeyCode.D, Vector2.right * speed);
	}

	private Dictionary<KeyCode, Vector3> translationByKeyCode;

	Vector3 TranslationByKeyCode(KeyCode key) {
		return translationByKeyCode[key];
	}

	#region implemented abstract members of KeyDelegation
	public override void KeyPressed (KeyCode key)
	{
		transform.Translate(TranslationByKeyCode(key));
	}
	#endregion

}
