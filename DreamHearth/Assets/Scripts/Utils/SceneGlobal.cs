using UnityEngine;
using System.Collections;

public class SceneGlobal : MonoBehaviour {
//	public AudioClip splashScreen;
//	public AudioClip mainMenu;
//	public AudioClip inGameNight;
	public static AudioClip currentSceneMusic;
	public static float volume;
	static AudioClip previousTrack;
	void Awake ( ) {
		PlayerGlobals.GlobalVariables( );
		SceneGlobal.currentSceneMusic = audio.clip;
		InvokeRepeating("CheckMusicChange", 0.1f, 0.1f);
		DontDestroyOnLoad( this.gameObject );
	}
	
	public static void LoadSceneMusic(AudioClip trackToPlay)
	{
		SceneGlobal.currentSceneMusic = trackToPlay;
	}
	public static void LoadSceneMusic(AudioClip trackToPlay, float volume)
	{
		SceneGlobal.currentSceneMusic = trackToPlay;
		SceneGlobal.volume = volume;
	}
	
	void CheckMusicChange()
	{
		if(SceneGlobal.currentSceneMusic == null)
			return;
		if(previousTrack == null)
		{
			ChangeMusic();
		}
		else if(previousTrack != SceneGlobal.currentSceneMusic){
			ChangeMusic();			
		}
	}
	
	void ChangeMusic()
	{
		audio.clip = SceneGlobal.currentSceneMusic;
		previousTrack = SceneGlobal.currentSceneMusic;
		audio.loop = true;
		audio.volume = SceneGlobal.volume;
		Debug.Log("Now Playing Track: " + audio.clip.name.ToString());
		audio.Play();
		//TODO: Could add tween to fade in and out the music.
	}
	
}
