using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterController : MonoBehaviour
{
    public GameObject getter;
    private Vector3 whereToSpawn;
    [Header("Time until the object is destroyed")]
    public float DestroySec = 5;
    [Header("The price of the getter")]
    public int PriceGetter = 50;
    [Header("The number of points added after the getter's work")]
    public int EarnedPoints = 100;
    public GameObject resourcesPanel;

    public void SpawnGetter()
    {
        whereToSpawn = new Vector3(-129, 22, 50);
        var lice = Instantiate(getter, whereToSpawn, Quaternion.Euler(0, -135, 0)) as GameObject;
        Destroy(lice, DestroySec);
        //resourcesPanel.GetComponent<ResourcesController>().blood += EarnedPoints;
        Invoke("EarnPoints", DestroySec);
    }
    public void EarnPoints()
    {       
        {
            resourcesPanel.GetComponent<ResourcesController>().blood += EarnedPoints;
        }
    }

    public void SpawnLice()
    {
        if(resourcesPanel.GetComponent<ResourcesController>().blood < PriceGetter)
        {
            return;
        }
        resourcesPanel.GetComponent<ResourcesController>().blood -= PriceGetter;
        SpawnGetter();
    }

}