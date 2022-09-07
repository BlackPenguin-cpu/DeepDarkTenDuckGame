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

    public SAttackItemDictionary()
    {
        this.itemName = "Null";
        this.shopLevel = 0;
        this.type = EItemType.ETC;
        this.dmg = 0;
        this.range = 0;
        this.cost = 0;
        this.cleanHitPoint = 0;
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

    public SShilldItemDictionary()
    {
        this.itemName = "Null";
        this.shopLevel = 0;
        this.type = EItemType.ETC;
        this.dmgReduction = 0;
        this.defCnt = 0;
        this.cost = 0;
        this.defSuccess = 0;
    }
}
[CreateAssetMenu(fileName = "Items Data", menuName = "Scriptable Object/Items Data")]
public class Items : ScriptableObject
{
    public List<SAttackItemDictionary> attackItems;
    public List<SShilldItemDictionary> shilldItems;
}
