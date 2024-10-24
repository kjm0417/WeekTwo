using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QueastDataSO", menuName = "QueastDataSO/EncounterQuestSO", order = 0)]

public class EncounterQuestSO : QuestDataSO
{
    [Header("EncounterQuest")]
    public string Goal;//목표

    public override void DebugQuests()
    {
        Debug.Log($" - {QuestName} (최소레벨 {QuestRequiredLevel})");
        Debug.Log($"{Goal}과 대화하기");
    }
}
