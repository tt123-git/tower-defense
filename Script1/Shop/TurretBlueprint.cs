using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TurretBlueprint
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;

    public GameObject upgraded2Prefab;
    public int upgrade2Cost;
    public int GetSellAmount()
    {
        return cost / 3;
    }
}
