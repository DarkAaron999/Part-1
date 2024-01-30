using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHazard : MonoBehaviour
{
    // Grabing the player gameobject
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for collision enter
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Turns off the player gameobject
        player.SetActive(false);
    }
}
