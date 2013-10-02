using UnityEngine;
using System.Collections;

public class DiaryNextButton : MonoBehaviour {
	public float waitTime;
	public GameObject objectToEnable;
	
	void Start () {
		Invoke ( "EnableObject", waitTime );
	}
	void EnableObject () {
		objectToEnable.SetActive( true );
	}
}
