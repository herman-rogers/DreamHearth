using UnityEngine;
using System.Collections;

public class OrbCollector : MonoBehaviour {
	// This script can be placed on an 2D object
	//to give it simple AI that moves
	//it towards a player character
	//-- perfect for orb collection/Simple Enemies
	public float movementSpeed 	= 10;
	public float rotationSpeed 	= 5;
	public bool enemyAI	   		= false;
	const float movementSpeedConst = 100.0f;
	bool toggle;
	
	Transform  target;
	void Start ( ) {
		if ( enemyAI ){
			InvokeRepeating( "Animate2DEnemy", 0.01f, 0.009f );
			return;
		}
		//InvokeRepeating( "AnimateOrb", 0.01f, 0.009f );
	//}
//	void AnimateOrb( ) {
//		transform.rotation = Quaternion.Slerp( transform.rotation,
//		Quaternion.LookRotation( target.position - transform.position ), ( rotationSpeed * Time.deltaTime) );
//		transform.position += ( transform.forward * movementSpeed * Time.deltaTime );
	}
	void Animate2DEnemy( ){
		target = GameObject.FindWithTag( "Player" ).transform; // can replace this with an event system
															  //Preferably with an OnCollisionEnter - type
		movementSpeed += 0.001f;
		transform.position = Vector3.MoveTowards( transform.position, target.position, ( movementSpeed / movementSpeedConst ) * Time.deltaTime );
		
//		Vector3 newTrans = transform.position;
//		newTrans.x += Mathf.Sin (Time.deltaTime);
//		newTrans = Vector3.Lerp( transform.position, target.position, Time.deltaTime );
//		transform.position = newTrans;
	}
}