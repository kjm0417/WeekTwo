using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QueastDataSO", menuName = "QuestDataSO/QuestData", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("QuestData")]
    public string QuestName; //�̸�
    public int QuestRequiredLevel; //���෹��
    public int QuestNPC; //npc ��ȣ
    public List<int> QuestPrereQuisites; //������ ����Ʈ
}

