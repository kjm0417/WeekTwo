using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의
    private static QuestManager instance;
    public QuestDataSO Quests;

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
}
