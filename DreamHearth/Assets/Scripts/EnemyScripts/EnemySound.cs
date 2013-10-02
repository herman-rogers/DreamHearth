using UnityEngine;
using System.Collections;

public class EnemySound : MonoBehaviour {

	public AudioClip DeathClip;
	
	public void PlayClipAndKill()
	{
		audio.PlayOneShot(DeathClip);
		StartCoroutine(Kill (DeathClip.length));
	}
	
	//Wait for waitTime then destroy self.
	IEnumerator Kill(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		//kill self
		Destroy(this.gameObject);		
	}
	
}
