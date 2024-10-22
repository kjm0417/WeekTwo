using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;
    public QuestDataSO Quests;

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
}
