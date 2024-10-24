using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;
    public List<QuestDataSO> Quests;

    // [�������� 2] ���� ������Ƽ ����
    //�ܺο��� ����� �� ����Ǵ� ���� �� �Ѿ���� �ʰ� �ϱ� ���� - ���� ������ �ʿ��� ���� Ȯ������ ����
    public static QuestManager Instance
    {
        get
        {
            return instance;
        }
        set
        {
            if(instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
                if(instance == null)
                {
                    instance = new GameObject().AddComponent<QuestManager>();
                }
            }
        }
    }

    // [�������� 3] �ν��Ͻ� �˻� ����
    private void Awake()
    {
        if(instance != null)
        {
           Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

    }

    private void Start()
    {
        //QuestType();
    }

    ////�������� 3
    //public void QuestType()
    //{
    //    int questIndex = 1;
    //    foreach(QuestDataSO quest in Quests) 
    //    {
    //        if(quest is MonsterQuestDataSO monsterQuest)
    //        {
    //            Debug.Log($"Quest {questIndex} - {monsterQuest.QuestName} (�ּҷ��� {monsterQuest.QuestRequiredLevel})");
    //            Debug.Log($"{monsterQuest.mosterName}�� {monsterQuest.monsterCount}");
    //        }
    //        else if(quest is EncounterQuestSO encounterQuest)
    //        {
    //            Debug.Log($"Quest {questIndex} - {encounterQuest.QuestName} (�ּҷ��� {encounterQuest.QuestRequiredLevel})");
    //            Debug.Log($"{encounterQuest.Goal}�� ��ȭ�ϱ�");

    //        }
    //        questIndex++;
    //    }
    //}
}
