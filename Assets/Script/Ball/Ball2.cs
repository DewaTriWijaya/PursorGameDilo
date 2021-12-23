using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    private int speed = 50;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(3, 15) * speed, ForceMode2D.Force);
    }
}
