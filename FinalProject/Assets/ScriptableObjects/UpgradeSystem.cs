using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObjects",menuName = "ScriptableObjects/UpgradeSystem")]
public class UpgradeSystem : ScriptableObject
{
    
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
        
    
    public int SbAmmount = 10;
    public int EhAmount = 10;
    public int Armor = 10;
    public int lSpellCost = 10;
    public int vSpellCost = 10;
    public int iSpellCost = 10;
    public bool iUnlock = false;
    public bool vUnlock = false;
    public bool LUnlock = false;
    
  
}
