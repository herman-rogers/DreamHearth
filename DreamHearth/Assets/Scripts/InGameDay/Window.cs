using UnityEngine;
using System.Collections;

public class Window : MonoBehaviour {
	
	public GameObject openWindow;
	public GameObject closedWindow;
	
	void OnClickedGood()
	{
		PlayerGlobals.isWindowOpen = false;
		NGUITools.AddChild(this.transform.parent.gameObject, closedWindow);
		Destroy(this.gameObject);
	}
	
	void OnClickedBad()
	{
		PlayerGlobals.isWindowOpen = true;
		NGUITools.AddChild(this.transform.parent.gameObject, openWindow);
		Destroy(this.gameObject);
	}
}
