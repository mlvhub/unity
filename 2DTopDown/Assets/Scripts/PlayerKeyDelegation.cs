using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class PlayerKeyDelegation : KeyDelegation {
	// Use this for initialization
	protected void Start () {
		supportedKeyCodes = new List<KeyCode>() { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
	}
}
