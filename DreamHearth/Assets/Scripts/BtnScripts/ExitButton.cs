using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour{
	//use this only to exit out of a in-game menu
	public GameObject parentObject;
	void OnClick( ){
		Time.timeScale = 1;
		Destroy( parentObject );
	}
	
}
