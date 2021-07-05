using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesController : MonoBehaviour
{
    public Text resourcesText;
    [Header("Resources")]
    public int blood;

    void Update()
    {
        resourcesText.text = "Blood points: " + blood;
    }
}
