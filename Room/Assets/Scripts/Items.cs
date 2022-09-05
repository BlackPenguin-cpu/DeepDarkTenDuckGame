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
    public EItemType type;
    public float dmg;
    public int range;
    public float cost;
    public float cleanHitPoint;

    public SAttackItemDictionary(string itemName, EItemType type, float dmg, int range, float cost, float cleanHitPoint)
    {
        this.itemName = itemName;
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
    public EItemType type;
    public float dmg;
    public int range;
    public float cost;
    public float cleanHitPoint;

    public SShilldItemDictionary(string itemName, EItemType type, float dmg, int range, float cost, float cleanHitPoint)
    {
        this.itemName = itemName;
        this.type = type;
        this.dmg = dmg;
        this.range = range;
        this.cost = cost;
        this.cleanHitPoint = cleanHitPoint;
    }
}
[CreateAssetMenu(fileName = "Items Data", menuName = "Scriptable Object/Items Data")]
public class Items : ScriptableObject
{
    public List<SAttackItemDictionary> attackItems;
    public List<SShilldItemDictionary> shilldItems;


}
