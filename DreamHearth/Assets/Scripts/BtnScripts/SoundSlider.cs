using UnityEngine;
using System.Collections;

public class SoundSlider : MonoBehaviour {
	public GameObject thumbSprite;
	static float setVolume = 1;
	void Awake( ){
		this.GetComponent< UISlider >( ).sliderValue = setVolume;
	}
	void OnSliderChange( float volume ){
		AudioListener.volume	= volume;
		setVolume 				= volume;
		if ( volume == 0 ){
			thumbSprite.GetComponent< UISprite >( ).spriteName = "SoundDown";
		}
		if ( volume > 0 ){
			thumbSprite.GetComponent< UISprite >( ).spriteName = "SoundUp";
		}
		
	}
}
