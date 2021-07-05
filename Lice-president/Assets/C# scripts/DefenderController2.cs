using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderController2 : MonoBehaviour
{
    public GameObject defender;
    private Vector3 whereToSpawn;
    [Header("The price of the defender")]
    public int PriceGetter = 100;
    public GameObject resourcesPanel;

    public void SpawnDefender()
    {
        whereToSpawn = new Vector3(50, 16, 47);
        var lice = Instantiate(defender, whereToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void SpawnLice()
    {
        if (resourcesPanel.GetComponent<ResourcesController>().blood < PriceGetter)
        {
            return;
        }
        resourcesPanel.GetComponent<ResourcesController>().blood -= PriceGetter;
        SpawnDefender();
    }

}
