using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private Vector2 target;
    private Vector2 direction;
    public float Speed;

    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        Destroy(gameObject, 2f);
        Vector2 PlayerPos = transform.position;

        direction = target - PlayerPos;
        transform.right = direction;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
