using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public float spawnZInterval = 6f;
    public GameObject[] obstaclePrefabs;
    public GameObject coinPrefab;
    public GameObject enemyPrefab;

    float lastSpawnZ;
    void Start(){ lastSpawnZ = spawnPoint.position.z; }

    void Update(){
        if(GameManager.Instance.IsPlaying){
            if(spawnPoint.position.z - lastSpawnZ > spawnZInterval){
                SpawnChunk(lastSpawnZ + spawnZInterval);
                lastSpawnZ += spawnZInterval;
            }
        }
    }

    void SpawnChunk(float zPosition){
        int lanes = 3;
        for(int lane=0; lane<lanes; lane++){
            float rnd = Random.value;
            Vector3 pos = new Vector3((lane-1)*2f, 0, zPosition);
            if(rnd < 0.2f){
                Instantiate(enemyPrefab, pos, Quaternion.identity);
            } else if(rnd < 0.5f){
                Instantiate(coinPrefab, pos + Vector3.up*0.5f, Quaternion.identity);
            } else if(rnd < 0.8f){
                int idx = Random.Range(0, obstaclePrefabs.Length);
                Instantiate(obstaclePrefabs[idx], pos, Quaternion.identity);
            }
        }
    }
}
