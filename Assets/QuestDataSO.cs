using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QueastDataSO", menuName = "QuestDataSO/QuestData", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("QuestData")]
    public string QuestName; //이름
    public int QuestRequiredLevel; //수행레벨
    public int QuestNPC; //npc 번호
    public List<int> QuestPrereQuisites; //선행퀘 리스트
}

