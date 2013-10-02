using UnityEngine;
using System.Collections;

public class MenuEndGame : MonoBehaviour {
	void OnClick ( ) {
		Application.LoadLevel( "MainMenu" );
	}
}
