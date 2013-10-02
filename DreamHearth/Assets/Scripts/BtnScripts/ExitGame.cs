using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {
	void OnClick ( ) {
#if UNITY_WEBPLAYER
		Application.LoadLevel("MainMenu");
#else
	 Application.Quit( );
#endif
	}

}
