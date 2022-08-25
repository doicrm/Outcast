using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Outcast/AI/Player")]
public class Player : Npc
{
    [Header("Player")]
    // public Journal journal = new Journal();
    private List<Quest> journal = new List<Quest>();
}

