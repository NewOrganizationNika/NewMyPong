using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    [SerializeField] private GameObject ball = null;
    private float speed;

    private void Awake()
    {
        speed = GetComponent<Player>().speed;
    }

    private void Update()
    {
        var dir = transform.position.y > ball.transform.position.y ? -1 : 1;
        transform.Translate(Vector2.up * (speed * dir * Time.deltaTime));
    }
}