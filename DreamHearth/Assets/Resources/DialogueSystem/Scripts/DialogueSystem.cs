using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour {
	
	//Public variables.
	public GameObject defaultMessageBox;
	//Private variables.
	
	private static DialogueSystem Instance;
	const string prefabLocation = "DialogueSystem/Prefabs/DialogueSystem";
	
	public static DialogueSystem GetInstance
	{
        get
        {			
			if(Instance == null)
			{
				GameObject singleton = (GameObject)Resources.Load(prefabLocation, typeof(GameObject));
				if(!singleton)
					Debug.LogError("DialogueSystem prefabLocation incorrect: Resource/" + prefabLocation);
				else
					Instance = (DialogueSystem)(((GameObject)Instantiate(singleton)).GetComponent<DialogueSystem>());
			}
			return Instance;
		}
	}

	public GameObject GetMessageBox(MessageBox msgBox)
	{
		defaultMessageBox.GetComponent<MessageBoxManager>().setupMessageBox(msgBox);
		return defaultMessageBox;
	}
	
	public GameObject CreateMessageBox(MessageBox msgBox, GameObject parent)
	{
		GameObject msgBoxGO = NGUITools.AddChild(parent, defaultMessageBox);
		msgBoxGO.GetComponent<MessageBoxManager>().setupMessageBox(msgBox);
		return msgBoxGO;
	}
	
	public GameObject CreateMessageBox(MessageBox msgBox, GameObject messageBox, GameObject parent)
	{
		GameObject msgBoxGO = NGUITools.AddChild(parent, messageBox);
		msgBoxGO.GetComponent<MessageBoxManager>().setupMessageBox(msgBox);
		return msgBoxGO;
	}
}

public class MessageBox
{
	public UIFont font;
	public UISprite sprite;
	
	public MessageBox(UIFont font, UISprite Sprite)
	{
		this.font = font;
		this.sprite = sprite;
	}
}

public static class Colours
{
	public static Color red = new Color(1f, 0f, 0f, 1f);
	
}
