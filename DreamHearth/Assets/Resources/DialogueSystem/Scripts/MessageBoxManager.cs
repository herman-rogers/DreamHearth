using UnityEngine;
using System.Collections;

public class MessageBoxManager : MonoBehaviour {
	
	public UILabel text;
	public UISprite box;
	public UIFont font;
	public UIButtonMessage goodButton;
	public UIButtonMessage badButton;
	
	
	public void setupMessageBox(MessageBox msgBox)
	{
//		this.text.font = msgBox.font;
		this.font = msgBox.font;
//		this.box = msgBox.sprite;
	}
	
	public void setupGoodButton(GameObject target, string method, string labelName)
	{
		goodButton.target = target;
		goodButton.functionName = method;
		goodButton.GetComponentInChildren<UILabel>().text = labelName;
	}
	
	public void setupBadButton(GameObject target, string method, string labelName)
	{
		badButton.target = target;
		badButton.functionName = method;
		badButton.GetComponentInChildren<UILabel>().text = labelName;
	}
	
}
