﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private Rigidbody2D body; // посилання за компонент

    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody2D>(); // одержуємо посилання на компонент
    }

    // Раз у кадр
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * 250);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            body.AddForce(Vector2.left * 250);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            body.AddForce(Vector2.right * 250);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            body.AddForce(Vector2.right * 250);
        }
    }
}
