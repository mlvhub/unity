using UnityEngine;
using System.Collections;

public abstract class PlatformInputHandler {

	//Improve Naming
	public abstract bool Touch();
	public abstract bool TouchBegin();
	public abstract bool TouchEnd();
	public abstract Vector3 TouchPosition();

	public bool TouchRight ()
	{
		return Touch() && TouchPosition().x > Screen.width / 2;
	}
	
	public bool TouchLeft ()
	{
		return Touch() && TouchPosition().x < Screen.width / 2;
	}

	public bool TouchTop ()
	{
		return Touch() && TouchPosition().y > Screen.height / 2;
	}
	
	public bool TouchBottom ()
	{
		return Touch() && TouchPosition().y < Screen.height / 2;
	}

}