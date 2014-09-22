using UnityEngine;
using System.Collections;

public class MobileInputHandler : PlatformInputHandler {
	#region implemented abstract members of PlatformInputHandler

	public override bool Touch ()
	{
		return Input.touchCount > 0;
	}

	public override bool TouchEnd ()
	{
		return Input.GetTouch(0).phase == TouchPhase.Ended;
	}

	public override Vector3 TouchPosition ()
	{
		return Input.GetTouch(0).position;
	}
	
	public override bool TouchBegin ()
	{
		return Input.GetTouch(0).phase == TouchPhase.Began;
	}

	#endregion
	
	
	
}