using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {
	public bool Drag2D	= false;
	bool drag 			= false;
	float Height2D;
	float distance;
	void Start( ){
		Height2D = transform.position.z;
	}
	void OnMouseDown( ){
		distance = Vector3.Distance( transform.position, Camera.main.transform.position );
		drag 	 = true;
	}
	void OnMouseUp( ){
		drag = false;
	}
	void Update ( ) {	
		if ( drag ){
			SetRayCast( );
		}
	}
	void SetRayCast( ){
		Ray myRay 			= Camera.main.ScreenPointToRay( Input.mousePosition );
		Vector3 rayPoint 	= myRay.GetPoint( distance );
		transform.position 	= rayPoint;
		if ( Drag2D ){
			Set2DDrag( );
		}
	}
	void Set2DDrag( ){
		transform.position 	= new Vector3(transform.position.x, transform.position.y, Height2D);
	}
}