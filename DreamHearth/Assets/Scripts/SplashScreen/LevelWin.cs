using UnityEngine;
using System.Collections;

public class LevelWin : MonoBehaviour {	
	public float timeDisplayedFor = 5.0f;
	
	void Start()
	{
		Invoke("FinishSplash", timeDisplayedFor);	
	}
	void FinishSplash( ){
		Application.LoadLevel( "DayScene" );
	}
}
