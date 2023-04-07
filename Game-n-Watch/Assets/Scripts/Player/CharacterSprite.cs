using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSprite : MonoBehaviour
{
    public Sprite upSprite, downSprite, leftSprite, rightSprite; // sprites for each direction
    private SpriteRenderer spriteRenderer; // reference to the sprite renderer component

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // get the sprite renderer component
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.sprite = leftSprite;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.sprite = rightSprite;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            spriteRenderer.sprite = upSprite;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            spriteRenderer.sprite = downSprite;
        }
    }
}
