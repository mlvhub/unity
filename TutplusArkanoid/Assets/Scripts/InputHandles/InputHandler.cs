using UnityEngine;
using System.Collections;

public class InputHandler {

	//Improve Naming
	private static RuntimePlatform platform;
	public static PlatformInputHandler PlatformInput {
		get;
		set;
	}

	static InputHandler() {
		platform = Application.platform;
		PlatformInput = GetPlatformInputHandler(platform);
	}

	static PlatformInputHandler GetPlatformInputHandler(RuntimePlatform platform) {
		PlatformInputHandler currentPlatformHandler = null;
		switch (platform) {
			case RuntimePlatform.Android:
			case RuntimePlatform.IPhonePlayer:
				currentPlatformHandler = new MobileInputHandler();
				break;
			case RuntimePlatform.WindowsEditor:
			case RuntimePlatform.OSXEditor:
			default:
				currentPlatformHandler = new EditorInputHandler();
				break;
			}

		return currentPlatformHandler;
	}

}
