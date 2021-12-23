using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3 : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 8;

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().AddForce(speed * new Vector2(moveHorizontal, moveVertical));

    }
}
