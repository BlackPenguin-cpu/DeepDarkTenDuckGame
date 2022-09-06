using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum EItemType
{
    RESPIRATORY,
    MENTAL,
    PHYSICS,
    ETC,
    END
}
[Serializable]
public class SAttackItemDictionary
{
    public string itemName;
    public int shopLevel;
    public EItemType type;
    public float dmg;
    public int range;
    public float cost;
    public float cleanHitPoint;

    public SAttackItemDictionary(string itemName,int shopLevel, EItemType type, float dmg, int range, float cost, float cleanHitPoint)
    {
        this.itemName = itemName;
        this.shopLevel = shopLevel;
        this.type = type;
        this.dmg = dmg;
        this.range = range;
        this.cost = cost;
        this.cleanHitPoint = cleanHitPoint;
    }
}
[Serializable]
public class SShilldItemDictionary
{
    public string itemName;
    public int shopLevel;
    public EItemType type;
    public float dmgReduction;
    public int defCnt;
    public float cost;
    public float defSuccess;

    public SShilldItemDictionary(string itemName,int shopLevel ,EItemType type, float dmgReduction, int defCnt, float cost, float defSuccess)
    {
        this.itemName = itemName;
        this.shopLevel = shopLevel;
        this.type = type;
        this.dmgReduction = dmgReduction;
        this.defCnt = defCnt;
        this.cost = cost;
        this.defSuccess = defSuccess;
    }
}
[CreateAssetMenu(fileName = "Items Data", menuName = "Scriptable Object/Items Data")]
public class Items : ScriptableObject
{
    public List<SAttackItemDictionary> attackItems;
    public List<SShilldItemDictionary> shilldItems;
}
