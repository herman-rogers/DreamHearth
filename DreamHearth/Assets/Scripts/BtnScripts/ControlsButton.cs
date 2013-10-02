using UnityEngine;
using System.Collections;

public class ControlsButton : MonoBehaviour {
	public GameObject parentRoot;
	public GameObject optionsPrefab;
	void OnClick( ){
		Time.timeScale = 0;
		GameObject controlMenu = NGUITools.AddChild( parentRoot, optionsPrefab  );
		controlMenu.transform.localPosition = new Vector3( 0, 0, -700 );
		controlMenu.transform.localScale	= new Vector3( 0.53f, 0.747f, 1);
	}
}
