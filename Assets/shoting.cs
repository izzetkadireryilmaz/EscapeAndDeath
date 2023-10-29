using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoting : MonoBehaviour
{
    private Vector2 direction;
    void Start()
    {
        
    }
   
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 PlayerPos = transform.position;

        direction = MousePos - PlayerPos;
        transform.right = direction;  

    }
}
