using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의
    private static QuestManager instance;
    public List<QuestDataSO> Quests;

    // [구현사항 2] 정적 프로퍼티 정의
    //외부에서 사용할 때 변경되는 값을 막 넘어오지 않게 하기 위해 - 말에 수정이 필요함 아직 확실하지 않음
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

    // [구현사항 3] 인스턴스 검사 로직
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

    ////구현사항 3
    //public void QuestType()
    //{
    //    int questIndex = 1;
    //    foreach(QuestDataSO quest in Quests) 
    //    {
    //        if(quest is MonsterQuestDataSO monsterQuest)
    //        {
    //            Debug.Log($"Quest {questIndex} - {monsterQuest.QuestName} (최소레벨 {monsterQuest.QuestRequiredLevel})");
    //            Debug.Log($"{monsterQuest.mosterName}를 {monsterQuest.monsterCount}");
    //        }
    //        else if(quest is EncounterQuestSO encounterQuest)
    //        {
    //            Debug.Log($"Quest {questIndex} - {encounterQuest.QuestName} (최소레벨 {encounterQuest.QuestRequiredLevel})");
    //            Debug.Log($"{encounterQuest.Goal}과 대화하기");

    //        }
    //        questIndex++;
    //    }
    //}
}
