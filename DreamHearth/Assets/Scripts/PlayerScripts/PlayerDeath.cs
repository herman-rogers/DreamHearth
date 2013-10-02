using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	private float playerLife;
	void Update( ){
		playerLife = PlayerPrefs.GetFloat( "playerHealth" );
		if ( playerLife <= 0 ){
			Invoke( "StartEndGame", 1.0f );
		}
	}
	void StartEndGame( ){
		SceneFadeInOut.LoadLevel( "EndGame", 0.3f, 0.3f, Color.magenta );
	}
}
