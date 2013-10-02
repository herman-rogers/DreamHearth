using UnityEngine;
using System.Collections;

public class Radiator : MonoBehaviour {
	
	public GameObject radiator;
	public GameObject radiatorMsg;
	
	void Start()
	{
		bool temp = (PlayerGlobals.currentLevel >= 3);
		NGUITools.SetActive(radiator, PlayerGlobals.isRadiatorOn);
		NGUITools.SetActive(radiatorMsg, temp);
	}
	
	void OnClickedGood()
	{
		PlayerGlobals.isRadiatorOn = true;
		NGUITools.SetActive(radiator, true);
		NGUITools.SetActive(radiatorMsg, true);
	}
	
	void OnClickedBad()
	{
		PlayerGlobals.isRadiatorOn = false;
		NGUITools.SetActive(radiator, false);
		NGUITools.SetActive(radiatorMsg, false);
	}
	
}
