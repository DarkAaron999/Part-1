using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oilSpill : MonoBehaviour
{
    public GameObject car;
    public float carSpeed = 200;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.Rotate(0, 0, 5 * Time.deltaTime);
        transform.Rotate(transform.forward, 5 *Time.deltaTime);
    }
}
