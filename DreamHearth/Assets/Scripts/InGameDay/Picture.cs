using UnityEngine;
using System.Collections;

public class Picture : MonoBehaviour {

	public GameObject pictureNormal;
	public GameObject pictureChanged;
	
	public GameObject messageInteractive;
	public GameObject messageNormal;
	
	void Start()
	{
		bool isHighEnoughProgress = (PlayerGlobals.currentLevel >= 3);
		NGUITools.SetActive(messageInteractive, isHighEnoughProgress);
		NGUITools.SetActive(messageNormal, !isHighEnoughProgress);
	}
	
	void OnClickedGood()
	{
		PlayerGlobals.isPictureChanged = true;
		NGUITools.AddChild(this.transform.parent.gameObject, pictureChanged);
		Destroy(this.gameObject);
	}
	
	void OnClickedBad()
	{
		PlayerGlobals.isPictureChanged = false;
		NGUITools.AddChild(this.transform.parent.gameObject, pictureNormal);
		Destroy(this.gameObject);
	}
}
