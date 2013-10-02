using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	public UISprite warmthBar;
	public UISprite fader;
	void Start( ){
		InvokeRepeating( "UpdateFillBar", 0.01f, 0.009f );
	}
	
	void OnTriggerEnter( Collider objectCollider ){
		float enemyDamage = objectCollider.gameObject.GetComponent< EnemyDestroyClick >( ).enemyDamage;
		if ( objectCollider.tag == "Enemy" ){
			PlayerGlobals.playerHealth = PlayerGlobals.playerHealth - enemyDamage;
			PlayerGlobals.GlobalVariables( );
			if(fader != null)
			{
				//If your number X falls between A and B, and you would
				//like Y to fall between C and D, you can apply the following linear transform:
				//Y = (X-A)/(B-A) * (D-C) + C
				float x = warmthBar.fillAmount; 
				fader.alpha = 1.0f - (((x-0.0f)/(1.0f - 0.0f) * (1.0f-0.6f)) + 0.6f);
			}
		}
	}
	void UpdateFillBar( ){
		warmthBar.fillAmount = PlayerGlobals.playerHealth;
	}
}
