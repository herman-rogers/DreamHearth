using UnityEngine;
using System.Collections;

public class EnemyDestroyClick : MonoBehaviour {
	public float clickDamage 	= 0.34f;
	public float enemyDamage 	= 0.2f;
	public float pointsAwarded 	= 3.0f;
	public UISprite progressBar;
	public GameObject monsterSound;
	float enemyHealth = 1.0f;
	void OnClick ( ) {
		enemyHealth -= clickDamage;
		progressBar.fillAmount = progressBar.fillAmount - clickDamage;
		if ( enemyHealth <= 0.0f ){
			PlayerGlobals.playerPoints += pointsAwarded;
			PlayerGlobals.GlobalVariables( );
			StartCoroutine("DestroyPlease");
		}
	}
	void OnTriggerEnter ( Collider objectCollider ) {
		if ( objectCollider.tag == "Player" ){
			StartCoroutine("DestroyPlease");
		}
	}
	IEnumerator DestroyPlease()
	{
		yield return new WaitForSeconds(0.09f);
		monsterSound.transform.parent = this.transform.parent;
		monsterSound.GetComponent<EnemySound>().PlayClipAndKill();
		Destroy( this.gameObject );
	}
}
