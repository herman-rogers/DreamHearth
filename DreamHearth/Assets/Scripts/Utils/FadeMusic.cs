using UnityEngine;
using System.Collections;

public class FadeMusic : MonoBehaviour {
	float volumeDown = 1;
//	float volumeUp   = 0;
	void Awake( ){
		//CancelInvoke( );
		InvokeRepeating( "FadeInMusic", 0.01f, 0.009f );
	}
//	void OnClick( ){
//		CancelInvoke( );
//		InvokeRepeating( "FadeOutMusic", 0.01f, 0.001f);
//	}
	void FadeOutMusic( ){
		volumeDown -= Time.deltaTime;
		AudioListener.volume = volumeDown;
	}
//	void FadeInMusic( ){
//		volumeUp += Time.deltaTime;
//		AudioListener.volume = volumeUp;
//	}
}
