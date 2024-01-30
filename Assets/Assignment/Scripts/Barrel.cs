using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    // Grabbing the SpriteRenderer component
    SpriteRenderer spriteRenderer;
    // Grabbing the current barrel sprite
    public Sprite currentSprite;
    // Grabbing the newSprite
    public Sprite newSprite;
    // Grabbing the player gameobject
    public GameObject player;
    void Start()
    {
        // Getting the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
        // At start shows the current sprite
        spriteRenderer.sprite = currentSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player gameobject collides change barrel to new sprite
        if (collision.gameObject == player)
        {
            // Getting the new sprite for the barrel 
            spriteRenderer.sprite = newSprite;
        }
    }
}
