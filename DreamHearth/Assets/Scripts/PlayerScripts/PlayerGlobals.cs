using UnityEngine;
using System.Collections;

public static class PlayerGlobals{	
	//	public static Color orange = new Color( 1.0f, ( 188f / 255f ), ( 11f / 255f ), 1.0f ) );
	public static float playerPoints = 0;
	public static float playerHealth = 1;
	public static float playerTimer	 = 120;
	public static int currentLevel 	 = 1;
	public static int currentDiary	 = 1;
	public static bool isDay{set; get;}
	public static bool isRadiatorOn{set; get;}
	public static bool isWindowOpen{set; get;}
	public static bool isDoorOpen{set; get;}
	public static bool isPictureChanged{set; get;}
	public static bool isLampOn{set; get;}
	public static void GlobalVariables ( ) {
		PlayerPrefs.SetFloat( "playerPoints", playerPoints );
		PlayerPrefs.SetFloat( "playerHealth", playerHealth );
		PlayerPrefs.SetFloat( "playerTimer", playerTimer );
		PlayerPrefs.SetFloat( "currentLevel", currentLevel );
	}
}