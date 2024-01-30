using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // For the player to use vectors2D
    Vector2 direction;

    // To add rigidbody
    public Rigidbody2D rigidbody;
    // To set the value for force
    public float force = 150;
    void Start()
    {
        // To get the component for rigidboy
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // keyboard inputs for the movement of player
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    // Function for players physics
    private void FixedUpdate()
    {
        //To add force to the rigidbody
        rigidbody.AddForce (direction * force * Time.deltaTime);
    }
}
