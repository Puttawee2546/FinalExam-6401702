using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    
        [SerializeField] float speed = 5;
    private Vector3 Move;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveX += -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveY += 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY -= 1f;
        }

        Move = new Vector3(moveX, moveY).normalized;


    }

    private void FixedUpdate()
    {
        rigidbody.velocity = Move * speed;
    }
}

