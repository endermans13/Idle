using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAction", menuName = "ActionLibrary/Actions")]
public class  ActionData : ScriptableObject
{
    public string actionName;
    public string description;
    public Sprite icon;
    public int maxStackSize = 99;
    public int diceAmount = 1;
    public int diceDamage = 4;
    public int firstPassive = 1;
    public int lastPassive = 1;
    public float goldValue;
}