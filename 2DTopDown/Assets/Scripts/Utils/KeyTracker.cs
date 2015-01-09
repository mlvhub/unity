using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyTracker {
	
	private List<KeyCode> keysPressed;
	
	public KeyTracker()
	{
		keysPressed = new List<KeyCode>();
	}
	
	public void KeyPressed(KeyCode key)
	{
		if (!keysPressed.Contains(key))
			this.keysPressed.Add(key);
	}
	
	public void KeyReleased(KeyCode key)
	{
		this.keysPressed.Remove(key);
	}
	
	public KeyCode LastKeyPressed()
	{
		return keysPressed[keysPressed.Count - 1];
	}

	public bool IsLastKeyPressed(KeyCode key) {
		return this.HasKeys() && key == this.LastKeyPressed();
	}

	public bool HasKeys() {
		return this.keysPressed.Count > 0;
	}
}