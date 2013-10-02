using UnityEngine;
using System.Collections;

public class MenuDay : MonoBehaviour {
	
	public GameObject menu;
	bool menuOpen = false;
	
	void OnMenuClicked()
	{
		GameObject menuInScene = NGUITools.AddChild(this.gameObject, menu);
		MessageManager.AddMessageBox(menuInScene);
	}
	
}
