using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int LevelLenght;
    public GameObject StartPlatformPrefab;
    public List<GameObject> Platform2Prefab = new List<GameObject>();
    public List<GameObject> LevelPlatformPrefab = new List<GameObject>();
    public GameObject FinishPlatformPrefab;
    
    void Start()
    {
        Vector3 startPlatformPosition = new Vector3(0, 0, 0);
        Instantiate(StartPlatformPrefab, startPlatformPosition, Quaternion.identity);

        int platform2PrefabIndex = Random.Range(0, Platform2Prefab.Count - 1);
        Vector3 platform2PrefabPosition = new Vector3(0, 0, startPlatformPosition.z + 20);
        Instantiate(Platform2Prefab[platform2PrefabIndex],platform2PrefabPosition,Quaternion.identity);
        
        for (int i = 1; i < LevelLenght - 2; i++)
        {
            int platformLevelPlatformPrefab = Random.Range(0, LevelPlatformPrefab.Count - 1);
            Vector3 platformLevelPrefabPosition = new Vector3(0, 0, startPlatformPosition.z + 20 + (20 * i));
            Instantiate(LevelPlatformPrefab[platformLevelPlatformPrefab], platformLevelPrefabPosition, Quaternion.identity);
        }
        Vector3 finishPlatformPosition = new Vector3(0, 0, (20 * LevelLenght) - 20);
        Instantiate(FinishPlatformPrefab, finishPlatformPosition, Quaternion.identity);

    }
}
