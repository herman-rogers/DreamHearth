using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject monster;
	public float spawnRate = 0.01f;
	public float spawnDelay = 0.1f;
	float timer = 0;
	Timer.NightPhase currentPhase = Timer.NightPhase.MID_NIGHT;
	void Awake ( ){
		InvokeRepeating( "StartSpawn", spawnDelay, spawnRate );
		Random.Range( 2.0f, 5.0f);
	}
	void StartSpawn( ){
		if( currentPhase == Timer.currentNightPhase )
			return;
		
		if ( Timer.currentNightPhase == Timer.NightPhase.EARLY_NIGHT ){
			CancelInvoke( );
			InvokeRepeating( "Spawn", spawnDelay, 1.0f/(spawnRate * Random.Range( 7.0f, 10.0f )) );
		}
		else if ( Timer.currentNightPhase == Timer.NightPhase.MID_NIGHT ){
			CancelInvoke( );
			InvokeRepeating( "Spawn", spawnDelay, 1.0f/(spawnRate * Random.Range( 5.5f, 7.0f )) );
		}
		else if ( Timer.currentNightPhase == Timer.NightPhase.EARLY_HOURS ){
			CancelInvoke( );
			InvokeRepeating( "Spawn", spawnDelay, 1.0f/(spawnRate * Random.Range( 2.5f, 5.5f )) );
		}
		else if ( Timer.currentNightPhase == Timer.NightPhase.NEARLY_MORNING ){
			CancelInvoke( );
			InvokeRepeating( "Spawn", spawnDelay, 1.0f/(spawnRate * Random.Range( 5.5f, 6.0f )) );
		}
	}
	void Spawn( ){
//		NGUITools.AddChild( this.gameObject , monster );
		Instantiate( monster, new Vector3( this.gameObject.transform.position.x + Random.Range( -0.3f, 0.3f ), 
							( this.gameObject.transform.position.y + Random.Range( -0.3f, 0.3f ) ), 
							this.gameObject.transform.position.z ), Quaternion.identity );
	}
}
