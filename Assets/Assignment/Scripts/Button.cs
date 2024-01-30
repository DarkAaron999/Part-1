using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Grabbing the player gameobject
    public GameObject player;
    // Grabbing the lazerHazard gameobject
    public GameObject lazerHazard;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for on collision enter
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player collides do turn off lazerHazard
        if (collision.gameObject == player)
        {
            // Turns off lazerHazard gameobject
            lazerHazard.SetActive(false);
        }
    }
}
