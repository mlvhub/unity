using UnityEngine;
using System.Collections;

public abstract class PlatformInputHandler {

	public abstract bool Touch();
	public abstract bool TouchBegin();
	public abstract bool TouchEnd();
	public abstract Vector3 TouchPosition();

}