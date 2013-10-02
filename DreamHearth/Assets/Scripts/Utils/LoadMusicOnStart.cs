using UnityEngine;
using System.Collections;

public class LoadMusicOnStart : MonoBehaviour {
	public AudioClip sceneMusic;
	public float volume = 1.0f;
	void Start () {
		if(sceneMusic != null)
			SceneGlobal.LoadSceneMusic(sceneMusic, volume);
		else
		{
			Debug.LogError("Scene's Music either null or not loaded correctly!");
		}
		Destroy(this);
	}

}
