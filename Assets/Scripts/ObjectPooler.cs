using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    #region Singleton Implementation
    private static ObjectPooler _instance;
    public static ObjectPooler Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion


    public GameObject []pooledObjects;
    public int pooledAmount;

    List<GameObject> pooledObjectsList;
    // Start is called before the first frame update
    void Start()
    {
        pooledObjectsList = new List<GameObject>();
        for(int i = 0; i < pooledAmount; i++)
        {
            AddGameObjectToPooledObjects();
        }
    }

    public GameObject GetGameObject()
    {
        for(int i = 0; i < pooledObjectsList.Count; i++)
        {
            if(!pooledObjectsList[i].activeSelf)
            {
                return pooledObjectsList[i];
            }
        }
        GameObject obj = AddGameObjectToPooledObjects();
        
        return obj;
    }

    GameObject AddGameObjectToPooledObjects()
    {
        GameObject obj = Instantiate(pooledObjects[Random.Range(0,2)]);
        obj.SetActive(false);
        pooledObjectsList.Add(obj);
        return obj;
    }
}
