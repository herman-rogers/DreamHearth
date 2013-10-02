using UnityEngine;
using System.Collections;

public class DialogueTest : MonoBehaviour {
	
	public UISprite sprite;
	public UIFont font;
	
	
	void OnClicked()
	{
		DialogueSystem.GetInstance.CreateMessageBox(
			new MessageBox(font, sprite), transform.parent.gameObject);	
	}
}
