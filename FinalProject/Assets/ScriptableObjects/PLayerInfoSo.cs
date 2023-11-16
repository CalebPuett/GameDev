using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects",menuName = "ScriptableObjects/Player")]
public class PLayerInfoSo : ScriptableObject
{
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
        
    
    public int coins = 0;
    public GameObject activeSpell;
    public int maxHealth;
    public float health;
    public float speed;
    public float spellSpeed;
    public int lSpellDamage;
    public int vSpellDamge;
    public int iSpellDamage;
    public int fSpellDamage;

}
