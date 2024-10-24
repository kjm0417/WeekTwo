using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QueastDataSO", menuName ="QueastDataSO/MonsterQuestDataSO", order =0)]
public class MonsterQuestDataSO : QuestDataSO
{
    [Header("MonsterQuest")]
    public string mosterName;
    public int monsterCount;

    public override void DebugQuests()
    {
        Debug.Log($" - {QuestName} (최소레벨 {QuestRequiredLevel})");
        Debug.Log($"{mosterName}를 {monsterCount}");
    }
}

