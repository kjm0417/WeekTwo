using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager instance;

    public Dictionary<string, ObjectPool> poolDictionary = new Dictionary<string, ObjectPool>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
