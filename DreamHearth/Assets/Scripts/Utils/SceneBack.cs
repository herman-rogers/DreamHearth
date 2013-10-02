using UnityEngine;
using System.Collections;

public class SceneBack : MonoBehaviour {
	void OnClick( ){
		SceneFadeInOut.LoadLevel( ( Application.loadedLevel - 1 ),  0.3f, 0.3f, Color.blue );
	}
}