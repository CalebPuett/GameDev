using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects",menuName = "ScriptableObjects/Player")]
public class PLayerInfoSo : ScriptableObject
{
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
        
    
    public int coins = 0;
    public GameObject activeSpell;
    public int maxHealth = 100;
    public float health = 100;
    public float speed = 5;
    public int lSpellDamage = 1;
    public int vSpellDamge = 1;
    public int iSpellDamage = 1;
    public int fSpellDamage = 1;

}
