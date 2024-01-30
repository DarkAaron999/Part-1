using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissileHazard : MonoBehaviour
{
    // For the speed of missile
    public Vector2 speed = new Vector2 (10, 0);
    // To use the rigidbody
    Rigidbody2D rigidbody;
    void Start()
    {
        // To get the component for rigidbody
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for movement of missile
    private void FixedUpdate()
    {
        // To make the missile move
        rigidbody.MovePosition(rigidbody.position +  speed * Time.deltaTime);
    }

    // Function for on collision enter
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destory the missile gameobject
        Destroy(gameObject);
    }
}
