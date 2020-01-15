using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    private float moveSpeed; 
    private float rotateSpeed;

    // Start is called before the first frame update
    private class Pawn
    {
        private float movespeed = 10f;
        private float rotatespeed = 90f;


    }
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(-Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(-Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
    }
}
