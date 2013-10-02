using UnityEngine;
using System.Collections;

public class JamesHeal : MonoBehaviour {
	void Awake( ){
		InvokeRepeating( "HealElysia", 0.01f, 1.0f );
	}
	void HealElysia( ){
		//Debug.Log( PlayerGlobals.playerHealth );
		if( PlayerGlobals.playerHealth < 1 ){
			PlayerGlobals.playerHealth += 0.01f;
			PlayerGlobals.GlobalVariables( );
		}
	}
}
