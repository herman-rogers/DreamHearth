using UnityEngine;
using System.Collections;

public class MessageDestroyer : MonoBehaviour {
	public void DestroyMessage( )
	{
		Destroy(this.gameObject);	
	}
}
