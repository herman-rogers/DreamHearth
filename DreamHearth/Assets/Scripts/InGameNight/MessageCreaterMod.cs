using UnityEngine;
using System.Collections;

public class MessageCreaterMod : MonoBehaviour {
	
	public GameObject messageBoxPrefab;
	public UIFont font;
	public UISprite sprite;
	public string messageText;
	public Vector3 msgBoxSize = new Vector3(400, 300, 1); 
	public string goodButtonText;
	public string badButtonText;
	public UIButtonMessage goodMessage;
	public UIButtonMessage badMessage;
	public string goodLabel;
	public string badLabel;
	
	GameObject msg;
	
	void CreateMessage()
	{
		if(!msg && PlayerGlobals.isDay)
		{
			msg = DialogueSystem.GetInstance.CreateMessageBox(
				new MessageBox(font, null), messageBoxPrefab, this.gameObject);
			msg.GetComponentInChildren<UISprite>().transform.localScale = msgBoxSize;
			MessageBoxManager msgBoxMan = msg.GetComponent<MessageBoxManager>();
			UILabel msgText = msgBoxMan.text;
			sprite = msgBoxMan.box;
			Debug.Log (sprite.gameObject.name + " " +
				sprite.transform.parent.gameObject.name + " " +
				sprite.transform.parent.parent.gameObject.name);
			msgText.text = messageText;
			
			msgText.lineWidth = (int)(sprite.transform.localScale.x - 20.0f);
			msgText.maxLineCount = Mathf.FloorToInt (sprite.transform.localScale.y / msgText.transform.localScale.y);
//			msgText.shrinkToFit = true;
			msg.GetComponentInChildren<UILabel>().font = font;
			msgBoxMan.setupGoodButton(goodMessage.target, goodMessage.functionName, goodLabel);
			msgBoxMan.setupBadButton(badMessage.target, badMessage.functionName, badLabel);
			MessageManager.AddMessageBox(msg);
		}
	}
	
}
