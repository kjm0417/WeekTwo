using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string name;
        public GameObject prefab;
    }

    public int poolSize = 300;

    public List<Pool> pools = new List<Pool>();

    private Dictionary<string , List<GameObject>> poolDictionary;

    private GameObject currentObject;

    void Start()
    {
        poolDictionary = new Dictionary<string, List<GameObject>>();

        foreach (Pool pool in pools)
        {
            List<GameObject> objectPool = new List<GameObject>();

            for (int i = 0; i <poolSize; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Add(obj);
            }

            poolDictionary.Add(pool.name, objectPool);
        }
    }


    public GameObject Get(string name)
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        if (poolDictionary.ContainsKey(name))
        {
            List<GameObject> pool = poolDictionary[name];
            foreach(GameObject obj in pool)
            {
                if (!obj.activeInHierarchy)
                {
                    obj.SetActive(true);
                    return obj;
                }
            }
        }
        return null;
    }

    public void Release(string name, GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        if(poolDictionary.ContainsKey(name))
        {
            obj.SetActive(false );
        }
    }

    public void ButtonOn(string name)
    {
        currentObject = Get(name);
    }

    public void ButtonOut(string name)
    {

        if (poolDictionary.ContainsKey(name))
        {
            List<GameObject> pool = poolDictionary[name];
            foreach(GameObject obj in pool)
            {
                if(obj.activeInHierarchy)
                {
                    obj.SetActive(false);
                    break;
                }
            }
        }
    }
}
