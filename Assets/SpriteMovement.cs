    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public Transform tf;
    public float speed = 1.0f;

}     
    void Start()
    {
    tf = gameObject.Getcomponent<Transform>();
    }
    void Update()
    {
    //move up if the player presses up
    if (Input.Getkey(KeyCode.UpArrow))
    { 
        tf.postion = tf.postion + Vector3.up + Time.deltatime * speed;
    }

    }
}
