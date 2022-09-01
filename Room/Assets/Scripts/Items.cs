using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public enum EItemType
{
    RESPIRATORY,
    MENTAL,
    PHYSICS,
    ETC,
    END
}
public struct SItemDictionary
{
    public string itemName;
    public EItemType type;
    public float dmg;
    public int range;
    public float cost;
    public float cleanHitPoint;
}
public class Items : MonoBehaviour
{
    public SItemDictionary[] itemInformations;
}
