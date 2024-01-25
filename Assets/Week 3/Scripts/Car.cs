using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    float acceleration;
    float steering;
    public float rotationSpeed = 100;
    public float forwardSpeed = 500;
    public float steeringSpeed = 200;
    public float boostSpeed = 25000;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Oillspill")
        {
            rigidbody.AddTorque(rigidbody.rotation + rotationSpeed * Time.deltaTime);
        }

        if (collision.gameObject.tag == "Boost")
        {
            Debug.Log("Entered");

            Vector2 force = transform.up * acceleration * boostSpeed * Time.deltaTime;
            rigidbody.AddForce(force);
        }
    }
}
