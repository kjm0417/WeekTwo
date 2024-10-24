using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QueastDataSO", menuName = "QueastDataSO/EncounterQuestSO", order = 0)]

public class EncounterQuestSO : QuestDataSO
{
    [Header("EncounterQuest")]
    public string Goal;//��ǥ

    public override void DebugQuests()
    {
        Debug.Log($" - {QuestName} (�ּҷ��� {QuestRequiredLevel})");
        Debug.Log($"{Goal}�� ��ȭ�ϱ�");
    }
}
