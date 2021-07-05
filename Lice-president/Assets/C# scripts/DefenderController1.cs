using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderController1 : MonoBehaviour
{
    public GameObject defender;
    private Vector3 whereToSpawn;
    [Header("The price of the defender")]
    public int PriceGetter = 100;
    public GameObject resourcesPanel;
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject lice;

    public void SpawnDefender()
    { if (lice == null)
        {
            whereToSpawn = new Vector3(x, y, z);
            lice = Instantiate(defender, whereToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
            resourcesPanel.GetComponent<ResourcesController>().blood -= PriceGetter;
        }
        
    }

    public void SpawnLice()
    {
        if (resourcesPanel.GetComponent<ResourcesController>().blood < PriceGetter)
        {
            return;
        }
        SpawnDefender();
    }

}
