using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour {
	
	public Texture2D cursor;
	public Texture2D clickCursor;
	
	Texture2D usedCursor;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void OnGUI () {
		if(Input.GetMouseButton(0))
			usedCursor = clickCursor;
		else
			usedCursor = cursor;
		Screen.showCursor = false;
		Vector3 mousePos = Input.mousePosition;
		Rect pos = new Rect(mousePos.x - usedCursor.width/4, (Screen.height - mousePos.y)- usedCursor.height/4,
			usedCursor.width/2, usedCursor.height/2);
		GUI.Label(pos, usedCursor);
	}
}
