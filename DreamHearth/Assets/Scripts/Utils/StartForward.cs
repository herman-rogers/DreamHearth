using UnityEngine;
using System.Collections;

public class StartForward : MonoBehaviour {
	void OnClick( ){
		SceneFadeInOut.LoadLevel( "DiaryDay1",  0.3f, 0.3f, new Color( 1.0f, ( 188f / 255f ), ( 11f / 255f ), 1.0f ) );
	}
}