using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteInEditMode]
public class BreakPrefabAD : MonoBehaviour {

    // Use this for initialization
    void Start () {
#if UNITY_EDITOR
        GameObject disconnectingObj = this.gameObject;
        PrefabUtility.DisconnectPrefabInstance(disconnectingObj);
        Object prefab = PrefabUtility.CreateEmptyPrefab("Assets/dummy.prefab");
        PrefabUtility.ReplacePrefab(disconnectingObj, prefab, ReplacePrefabOptions.ConnectToPrefab);
        PrefabUtility.DisconnectPrefabInstance(disconnectingObj);
        AssetDatabase.DeleteAsset("Assets/dummy.prefab");
		PrefabUtility.DisconnectPrefabInstance(gameObject);
#endif
    DestroyImmediate(this); // Remove this script
    }    
}