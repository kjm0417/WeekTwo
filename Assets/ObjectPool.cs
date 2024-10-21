using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
        }
    }

    public GameObject Get()
    {
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
        for(int i = 0;i < poolSize;i++)
        {
            GameObject obj = pool[i];
            if(!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
        for(int i = 0; i<poolSize;i++)
        {
            obj = pool[i];
            if(obj.activeInHierarchy)
            {
                obj.SetActive(false);
            }

        }

    }
}
