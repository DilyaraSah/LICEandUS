using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyController : MonoBehaviour
{
    public GameObject enemy;
    private Vector3 whereToSpawn;
    
    public void SpawnEnemy()
    {
        whereToSpawn = new Vector3(470, 0, 143);
        var lice = Instantiate(enemy, whereToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    void Update()
    {

    }
}
