using UnityEngine;
using System.Collections;
//Adds a pulsating Halo to object -- Requires object
//to have a light attached as a component
public class TouchGlow : MonoBehaviour {
	public float lightIntensity = 2;
	public bool holdToPulsate 	= false;
	public bool invert			= false;
	const float animationSpeed 	= 0.01f;
	const float smoothMove		= 0.009f;
	float lightRange;
	bool mouseUp;
	void OnMouseDown( ){
		mouseUp = false;
		StopPulsate( );
		InvokeRepeating( "IncreaseIntensity", animationSpeed, smoothMove );
	}
	void OnMouseUp( ){
		mouseUp = true;
		StopPulsate( );
		InvokeRepeating( "DecreaseIntensity", animationSpeed, smoothMove );
	}
	void IncreaseIntensity( ){
		lightRange += animationSpeed;
		if ( invert ){
			this.GetComponent< Light >( ).intensity = lightIntensity - lightRange;
		} else {
			this.GetComponent< Light >( ).intensity = lightRange;
		}
		if ( lightRange >= lightIntensity ){
			StopPulsate( );
			if ( holdToPulsate ){
				InvokeRepeating( "DecreaseIntensity", animationSpeed, smoothMove );
			}
		}
	}
	void DecreaseIntensity( ){
		if ( invert ){
			lightRange += animationSpeed;
			this.GetComponent< Light >( ).intensity = lightRange;
		} else {
			lightRange -= animationSpeed;
			this.GetComponent< Light >( ).intensity = lightRange;
		}
		if( lightRange <= 0 ){
			StopPulsate( );
			if ( !mouseUp ){
				InvokeRepeating( "IncreaseIntensity", animationSpeed, smoothMove );
			}
		}
	}
	void StopPulsate( ){
		CancelInvoke( );
	}
}