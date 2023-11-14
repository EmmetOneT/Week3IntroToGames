using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierCollisionHandler : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            BallData data = collision.gameObject.GetComponent<BallData>();
            spriteRenderer.color = data.BallColor;
        }
    }
}
