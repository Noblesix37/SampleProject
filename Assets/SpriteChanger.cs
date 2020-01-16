using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger: MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)


        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            Debug.LogError(message: "No Sprite Renderer Attached");
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
