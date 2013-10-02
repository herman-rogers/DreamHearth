using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	
	public GameObject openDoor;
	public GameObject closedDoor;
	
	void OnClickedGood()
	{
		PlayerGlobals.isDoorOpen = true;
		NGUITools.AddChild(this.transform.parent.gameObject, openDoor);
		Destroy(this.gameObject);
	}
	
	void OnClickedBad()
	{
		PlayerGlobals.isDoorOpen = false;
		NGUITools.AddChild(this.transform.parent.gameObject, closedDoor);
		Destroy(this.gameObject);
	}
}
