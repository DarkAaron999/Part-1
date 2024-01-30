using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawnPoint : MonoBehaviour
{
    // To pull the gameobject missile prefab
    public GameObject missilePrefab;
    // To pull the gameobject for the missile to with transfrom
    public Transform spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When enter in collider the trigger happens
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Spawns the missile at the spawnpoint position and rotation
        Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
