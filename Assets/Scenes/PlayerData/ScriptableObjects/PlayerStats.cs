using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class PlayerStats : ScriptableObject
{
    public int MovementSpeed;
}