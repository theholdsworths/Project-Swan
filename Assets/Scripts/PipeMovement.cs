using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-7, 0);

    public float range = 4;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value);

        // Pipes get destoryed after 8seconds of being spawned
        Destroy(gameObject, 8);
    }
}