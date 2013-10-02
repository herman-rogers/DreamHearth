using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {
	
	public GameObject lampBroken;
	public GameObject lampFixedOff;
	
	public GameObject messageInteractive;
	public GameObject messageNormal;
	
	void Start()
	{
		bool isHighEnoughProgress = (PlayerGlobals.currentLevel >= 2);
		NGUITools.SetActive(messageInteractive, isHighEnoughProgress);
		NGUITools.SetActive(messageNormal, !isHighEnoughProgress);
	}
	
	void OnClickedGood()
	{
		PlayerGlobals.isLampOn = true;
		NGUITools.AddChild(this.transform.parent.gameObject, lampFixedOff);
		Destroy(this.gameObject);
	}
	
	void OnClickedBad()
	{
		PlayerGlobals.isLampOn = false;
		NGUITools.AddChild(this.transform.parent.gameObject, lampBroken);
		Destroy(this.gameObject);
	}
}
