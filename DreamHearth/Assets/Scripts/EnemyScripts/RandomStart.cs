using UnityEngine;
using System.Collections;

public class RandomStart : MonoBehaviour {
	void Awake( ){
//		Vector3 monsterPosition = new Vector3( ( gameObject.transform.position.x + Random.Range( 0.01f, 0.05f ) ), gameObject.transform.position.y, gameObject.transform.position.z   );
//		this.gameObject.transform.localPosition += monsterPosition;
//		//monster.transform.position( 0, 0,0);//( Random.Range( 0.01f, 0.09f ) ), 0 );
		InvokeRepeating( "MoveSprite", 0.01f, 1.0f );
	
	}
	void MoveSprite( ){
		Vector3 monsterPosition = new Vector3( gameObject.transform.position.x , ( gameObject.transform.position.y + Random.Range( 0.01f, 0.05f ) ), gameObject.transform.position.z   );
		this.gameObject.transform.localPosition += monsterPosition;
		//monster.transform.position( 0, 0,0);//( Random.Range( 0.01f, 0.09f ) ), 0 );
	}
}
