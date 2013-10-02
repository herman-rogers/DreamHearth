using UnityEngine;
using System.Collections;
using System.Timers;

public class DragSelect : MonoBehaviour {
	//default activate is Mouse Interaction
	public bool objectActivate		= false;
	public bool changeTimer			= false;
	public bool changeOnClick 		= true;
	public float setTimer			= 3.0f;
	bool changeObject	 			= true;
	void OnMouseEnter( ){
		if ( !changeObject ){
			Activate( );
			if ( changeTimer ){
				Invoke ( "Deactivate", setTimer );
			}
		}
	}
	void OnMouseDown( ){
		if ( changeOnClick ){
			changeObject = true;
			Activate( );
			if ( changeTimer ){
				Invoke ( "Deactivate", setTimer );
			}
		}
	}
	void OnCollisionEnter( ){
		if ( objectActivate ){
			Activate( );
			if ( changeTimer ){
				Invoke ( "Deactivate", setTimer );
			}
		}
	}
	void Update( ){
		if (!objectActivate){
			MouseTrigger( );
		}
	}
	void MouseTrigger( ){
		if ( Input.GetMouseButton( 0 ) && changeObject ){
			changeObject = false;
		}
		if ( Input.GetMouseButtonUp( 0 ) && !changeObject ){
			changeObject = true;
			Deactivate( );
		}
	}
	void Activate( ){
		( gameObject.GetComponent( "Halo" ) as Behaviour ).enabled = true;
	}
	void Deactivate( ){
		( gameObject.GetComponent( "Halo" ) as Behaviour ).enabled = false;
	}
}