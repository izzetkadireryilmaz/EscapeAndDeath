using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private Vector3 mousePos;
    public GameObject Arrow;

    void Start()
    {

    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        Arrow.transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            shot();
        }

        Vector2 targetDirection = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.x);
        float rotateZ = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        Arrow.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
    }

    private void shot()
    {
        Instantiate(Arrow, transform.position, Quaternion.identity);

    }
}
