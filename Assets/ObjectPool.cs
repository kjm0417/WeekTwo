using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public string name;
    public GameObject prefab;

    public int poolSize = 300;

    public List<GameObject> pools = new List<GameObject>();

    void Start()
    {
        for(int i = 0; i< poolSize; i++)
        {
            GameObject go = Instantiate(prefab, transform);
            pools.Add(go);
        }
       
    }


    public GameObject Get(string name)
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.

       
    }

    public void Release(string name, GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
    
    }

    public void ButtonOn(string name)
    {

    }


}
