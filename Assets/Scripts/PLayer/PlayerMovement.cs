using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform target;
    public float speed=3;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.position, speed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Card")
        {
            print("Tocar Cards");
        }
        if (collision.gameObject.tag == "Weapon")
        {
            print("Tocar Weapon");
        }
    }
}

