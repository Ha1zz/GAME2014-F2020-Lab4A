using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    public float direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBound();
    }

    void Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }
    void CheckBound()
    {
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
