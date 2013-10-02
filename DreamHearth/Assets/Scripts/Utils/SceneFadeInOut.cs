using UnityEngine;
using System.Collections;

public class SceneFadeInOut : MonoBehaviour {
	private static SceneFadeInOut mInstance = null;
	private Material mMaterial 				= null;
	private string mLevelName				= "";
	private int mLevelIndex 				= 0;
	private bool mFading 					= false;
	
	private static SceneFadeInOut Instance{
		get{
			if ( mInstance == null ){
				mInstance = ( new GameObject( "SceneFadeInOut" ) ).AddComponent<SceneFadeInOut>( );
			}
			return mInstance;
		}
	}
	public static bool Fading{
		get { return Instance.mFading; }
	}
	private void Awake( ){
		DontDestroyOnLoad( this );
		mInstance = this;
		mMaterial = new Material( "Shader \"Plane/No zTest\" { SubShader { Pass " +
					"{ Blend SrcAlpha OneMinusSrcAlpha ZWrite Off Cull Off Fog { Mode Off } " +
					"BindChannels { Bind \"Color\",color } } } }" );
	}
	private void DrawQuad( Color aColor, float aAlpha ){
		aColor.a  = aAlpha;
		mMaterial.SetPass( 0 );
		GL.Color( aColor );
		GL.PushMatrix( );
		GL.LoadOrtho( );
		GL.Begin( GL.QUADS );
		GL.Vertex3( 0,0,-1 );
		GL.Vertex3( 0,1,-1 );
		GL.Vertex3( 1,1,-1 );
		GL.Vertex3( 1,0,-1 );
		GL.End( );
		GL.PopMatrix( );
	}
	private IEnumerator Fade( float aFadeOutTime, float aFadeInTime, Color aColor ){
		float t = 0.0f;
		while ( t < 1.0f ){
			yield return new WaitForEndOfFrame( );
			t = Mathf.Clamp01( t + Time.deltaTime / aFadeOutTime );
			DrawQuad( aColor, t );
		}
		if ( mLevelName != "" ){
			Application.LoadLevel( mLevelName );
		} else {
			Application.LoadLevel( mLevelIndex );
		}
		while ( t > 0.0f ){
			yield return new WaitForEndOfFrame( );
			t = Mathf.Clamp01( t - Time.deltaTime / aFadeInTime );
			DrawQuad( aColor, t );
		}
		mFading = false;
	}
	private void StartFade( float aFadeOutTime, float aFadeInTime, Color aColor ){
		mFading = true;
		StartCoroutine( Fade( aFadeOutTime, aFadeInTime, aColor ) );
	}
	public static void LoadLevel( string aLevelName, float aFadeOutTime, float aFadeInTime, Color aColor){
		if ( Fading ) return;
		Instance.mLevelName = aLevelName;
		Instance.StartFade( aFadeOutTime, aFadeInTime, aColor );
	}
	public static void LoadLevel( int aLevelIndex, float aFadeOutTime, float aFadeInTime, Color aColor ){
		if ( Fading ) return;
		Instance.mLevelName = "";
		Instance.mLevelIndex = aLevelIndex;
		Instance.StartFade( aFadeOutTime, aFadeInTime, aColor );
	}
	
	
		// 	public void FadeHandler( ){
		// 		CancelInvoke( "StartFade" );
		// 		InvokeRepeating( "SwitchFade", 0.01f, 0.009f );
		// 	}
	
	// 	float currentAlpha;
	// 	void Awake( ){
	// 		this.transform.localPosition 	= new Vector3( 0, 0, -1000 );
	// 		this.transform.localScale 		= new Vector3(1536, 2048);
	// 		TweenColor.Begin( this.gameObject, 0, textureColor );
	// 		InvokeRepeating( "StartFade", 0.01f, 0.009f );
	// 	}
	
	
	
	
// 	void StartFade( ){
// 		CancelInvoke( "SwitchFade" );
// 		TweenColor.Begin( this.gameObject, transitionSpeed, Color.clear );
// 		if ( currentAlpha <= 1.5f ){
// 			CancelInvoke( );
// 		}
// 	}
// 	void SwitchFade( ){
// 		if ( slowerTransitions ){
// 			TweenColor.Begin( this.gameObject, transitionSpeed, textureColor );
// 			if ( currentAlpha >= 0.95f  ){
// 				if( backButton ){
// 					Application.LoadLevel( Application.loadedLevel - 1 );
// 					return;
// 				}
// 				Application.LoadLevel( Application.loadedLevel + 1 );
// 			}
// 		}else{
// 			if ( backButton ){
// 				Application.LoadLevel( Application.loadedLevel - 1 );
// 				return;
// 			}
// 			Application.LoadLevel( Application.loadedLevel + 1 );
// 		}
// 	}
// 	void Update( ){
// 		if ( slowerTransitions ){
// 			currentAlpha = this.gameObject.GetComponent< UISprite >( ).alpha;
// 		}
// 	}
}
