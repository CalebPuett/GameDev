using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects",menuName = "ScriptableObjects/Player")]
public class PLayerInfoSo : ScriptableObject
{
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
        
    
    public int coins = 0;

}
