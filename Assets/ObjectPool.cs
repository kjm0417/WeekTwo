using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        string name;
        public GameObject Prefab;
    }

    public int poolSize = 300;

    public List<Pool> pools = new List<Pool>();

    void Start()
    {
        CratePool();
    }

    public void CratePool() //Ǯ ����
    {
        foreach(var pool in pools)
        {
            for(int i = 0;i<poolSize; i++)
            {
                GameObject obj = Instantiate(pool.Prefab,transform);
                obj.SetActive(false);
            }
        }
    }

    //public GameObject Get()
    //{
    //    // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
    //    if()
    //}

    public void Release(GameObject obj)
    {
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
    }
}
