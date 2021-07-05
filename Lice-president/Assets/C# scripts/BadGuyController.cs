using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyController : MonoBehaviour
{
    public GameObject enemy;
    private Vector3 whereToSpawn;
    public int startDelay = 2;
    public int repeatRate = 10;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    //public Transform EndPointEnemy1;
    //public Transform Warrior;

    public void SpawnEnemy()
    {
        whereToSpawn = new Vector3(x, y, z);
        var lice = Instantiate(enemy, whereToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatRate);
    }
    void Update()
    {
        //if (Vector3.Distance(transform.position, Warrior.position) < Vector3.Distance(transform.position, EndPointEnemy1.position))
        //{
        //    var heading = Warrior.position;
        //    heading.x -= 30;
        //    transform.position = Vector3.MoveTowards(transform.position, heading, 1);
        //}
        //else
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, EndPointEnemy1.position, 1);
        //}
    }
}
