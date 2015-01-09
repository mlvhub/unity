using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class KeyDelegation : MonoBehaviour {

	protected KeyTracker keyTracker;
	protected List<KeyCode> supportedKeyCodes;

	// Use this for initialization
	void Awake () {
		keyTracker = new KeyTracker();
		supportedKeyCodes = new List<KeyCode>();
	}
	
	// Update is called once per frame
	protected void Update () {
		foreach (KeyCode key in supportedKeyCodes)
		{
			if (Input.GetKeyDown(key))
				keyTracker.KeyPressed(key);
			
			if (Input.GetKeyUp(key))
				keyTracker.KeyReleased(key);
			
			if (keyTracker.HasKeys())
				KeyPressed(keyTracker.LastKeyPressed());
		}
	}

	public abstract void KeyPressed(KeyCode key);
}
