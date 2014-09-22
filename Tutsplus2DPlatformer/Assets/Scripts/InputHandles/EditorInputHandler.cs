using UnityEngine;
using System.Collections;

public class EditorInputHandler : PlatformInputHandler {
	#region implemented abstract members of PlatformInputHandler

	public override bool Touch ()
	{
		return Input.GetMouseButtonDown(0);
	}

	public override bool TouchEnd ()
	{
		return Input.GetMouseButtonUp(0);
	}

	public override Vector3 TouchPosition ()
	{
		return Input.mousePosition;
	}

	public override bool TouchBegin ()
	{
		return Input.GetMouseButtonDown(0);
	}

	#endregion



}
