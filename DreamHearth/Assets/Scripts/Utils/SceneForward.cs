using UnityEngine;
using System.Collections;

public class SceneForward : MonoBehaviour {
	void OnClick( ){
//		SceneFadeInOut.LoadLevel( ( Application.loadedLevel + 1 ),  0.3f, 0.3f, Color.cyan );
		Application.LoadLevel( "NightScene" );
	}
}