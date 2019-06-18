using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairColorChange : MonoBehaviour
{
    public Sprite[] sprites = Resources.LoadAll<Sprite>("MultipleSpriteFile");
    private SpriteRenderer spriteRenderer;
    private int prevIndex = -1;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (prevIndex != GameManager.instance.hairColor)
        {
            spriteRenderer.sprite = sprites[GameManager.instance.hairColor];
            prevIndex = GameManager.instance.hairColor;
        }
    }
}
