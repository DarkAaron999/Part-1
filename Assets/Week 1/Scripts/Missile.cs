using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 0);
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
