using UnityEngine;
using System.Collections;

public class NightDayCount : MonoBehaviour {
	bool flipValue = true;
	void Awake( ){
		Time.timeScale = 0;
	}
	void Update( ){
		if (gameObject.GetComponent< UISprite >( ).alpha <= 0 && flipValue == true){
			flipValue = false;
			Time.timeScale = 1;
		}
	}
}
