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

    public void CratePool() //풀 생성
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
    //    // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
    //    if()
    //}

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
    }
}
