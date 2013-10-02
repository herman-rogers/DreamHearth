using UnityEngine;
using System.Collections;

public class AnimationFlicker : MonoBehaviour {
	public float animateSpeed = 0.09f;
	bool mySwitch = false;
	void Awake( ) {
		InvokeRepeating( "Animate", 0.01f, 0.09f  );
	}
	void Animate( ){
		if (mySwitch){
			mySwitch = false;
		} else {
			mySwitch = true;
		}
		this.GetComponent< UIPanel >( ).enabled = mySwitch;
	}
}
