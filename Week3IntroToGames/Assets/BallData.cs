using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    public Color BallColor;
    SpriteRenderer spriteRenderer;

    Color[] possibleColors = new Color[] { Color.red, Color.green, Color.blue , Color.cyan, Color.magenta, Color.yellow};

    void Start()
    {
        int index = Random.Range(0, possibleColors.Length - 1);
        BallColor = possibleColors[index];

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = BallColor;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            Destroy(gameObject);
        }
    }
}
