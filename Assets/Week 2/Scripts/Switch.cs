using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color deactiveColor;
    public Color activeColor;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = deactiveColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        spriteRenderer.color = activeColor;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = deactiveColor;
    }
}
