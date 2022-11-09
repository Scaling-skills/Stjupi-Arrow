using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject FruitPrefab;
    public float respawnTime = 1.0f;
    
    // Use this for initialization
    void Start () {
        StartCoroutine(FruitSpawner());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(FruitPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-3, 3), 10, -55);
    }
    IEnumerator FruitSpawner(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}