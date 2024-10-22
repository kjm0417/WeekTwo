using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    

    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    private Dictionary<string, ObjectPool> pools = new Dictionary<string, ObjectPool>();

    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
        }
    }

    public GameObject Get()
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        for(int i = 0;i < poolSize;i++)
        {
            GameObject obj = pool[i];
            if(!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        for(int i = 0; i<poolSize;i++)
        {
            obj = pool[i];
            if(obj.activeInHierarchy)
            {
                obj.SetActive(false);
            }

        }

    }

    public void AddPool(string key, ObjectPool pool)
    {
        if (!pools.ContainsKey(key))
        {
            pools.Add(key, pool);
        }
    }

    public ObjectPool GetPool(string key)
    {
        if(pools.ContainsKey(key))
        {
            return pools[key];
        }

        return null;
    }
}
