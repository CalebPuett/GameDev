using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObjects",menuName = "ScriptableObjects/UpgradeSystem")]
public class UpgradeSystem : ScriptableObject
{
    
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
        
    
    public int SbAmmount;
    public int EhAmount;
    public int ssAmount;
    public int lSpellCost;
    public int vSpellCost;
    public int iSpellCost;
    public bool iUnlock = false;
    public bool vUnlock = false;
    public bool LUnlock = false;
    
  
}
