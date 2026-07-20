using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "NewItem", menuName = "Item Library/Item")]
public class ItemData :ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite icon;
    public int maxStackSize = 99;
    public float goldValue;
}
