using UnityEngine;
using System.Collections;

public class MessageCreater : MonoBehaviour {
	
	public UIFont font;
	public UISprite sprite;
	public string messageText;
	public Vector3 msgBoxSize = new Vector3(400, 300, 1); 
	
	GameObject msg;
	
	void CreateMessage()
	{
		if(!msg && PlayerGlobals.isDay)
		{
			msg = DialogueSystem.GetInstance.CreateMessageBox(
				new MessageBox(font, sprite), this.gameObject);
			msg.GetComponentInChildren<UISprite>().transform.localScale = msgBoxSize;
			UILabel msgText = msg.GetComponentInChildren<UILabel>();
			sprite = this.GetComponentInChildren<UISprite>();
			msgText.text = messageText;
			
			msgText.lineWidth = (int)(sprite.transform.localScale.x - 20.0f);
			msgText.maxLineCount = Mathf.FloorToInt (sprite.transform.localScale.y / msgText.transform.localScale.y);
//			msgText.shrinkToFit = true;
			msg.GetComponentInChildren<UILabel>().font = font;
			MessageManager.AddMessageBox(msg);
		}
	}
	
}
