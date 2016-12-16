using UnityEngine;
using System.Collections;
using uFrame.Attributes;


[ActionLibrary, uFrameCategory("Boolean")]
public static class ExampleScript {

	public static bool toggle(bool value) {
		return !value;
	}
}
