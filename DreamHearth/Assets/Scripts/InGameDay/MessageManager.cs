using UnityEngine;
using System.Collections;

public static class MessageManager {

	static GameObject currentMessageBox;
	static MessageDestroyer msgDest;
	
	public static void AddMessageBox(GameObject messageBox)
	{
		if(MessageManager.currentMessageBox != null)
		{
			MessageManager.msgDest = currentMessageBox.GetComponent<MessageDestroyer>();
			if(MessageManager.msgDest == null)
			{
				Debug.LogError("GameObject in Message Manager is not a message prefab or hasn't been set up correctly!");
				return;
			}
			MessageManager.msgDest.DestroyMessage();
		}
		MessageManager.currentMessageBox = messageBox;
	}
	
}
