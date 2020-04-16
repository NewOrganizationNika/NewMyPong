#pragma warning disable CS0649
using System;
using UnityEngine;

public class Player : MonoBehaviour, INullScore//, IGetPlayer
{
    public short count;
    public float speed;
    [SerializeField] private KeyCode up, down;
    public void NullScore()
    {
        count = 0;
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float sp;
        if (Input.GetKey(up))
            sp = speed;
        else if (Input.GetKey(down))
            sp = speed;
        else
            sp = 0f;
        Transform transform1;
        (transform1 = transform).Translate(Vector2.up * (sp * Time.deltaTime));
        var position = transform1.position;
        position = new Vector2(position.x, Mathf.Clamp(position.y, -4f, 4f));
        transform.position = position;
    }
}