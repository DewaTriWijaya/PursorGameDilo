using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallControl : MonoBehaviour
{
    Vector3 mousePosition;
    Rigidbody2D ball;
    Vector2 direction;
    float speed = 70f;
    public UnityEvent GetResource;

    private void Start()
    {
        ball = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //bola akan mengikuti kursor
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            ball.velocity = new Vector2(direction.x * speed, direction.y * speed);
        }
        else
        {
            ball.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "block")
        {
            Destroy(collision.gameObject);
            GetResource.Invoke();
        }
    }
}
