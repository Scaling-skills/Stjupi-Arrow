using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner0 : MonoBehaviour
 {
    public GameObject FruitPrefab;
    public float respawnTime = 1.0f;
    
    // Use this for initialization
    void Start () {
        StartCoroutine(FruitSpawner());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(FruitPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-3, 3), 10, 5);
    }
    IEnumerator FruitSpawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}