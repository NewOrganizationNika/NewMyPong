#pragma warning disable CS0649
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static bool IsPlaying;
    [SerializeField] private float ballSpeed;
    [SerializeField] private bool directionX, directionY, startGame;
    [SerializeField] private float randDirX = 1, randDirY = 1;

    public void Start()
    {
        startGame = false;
        transform.position = Vector3.zero;
        directionX = !directionX;
        directionY = !directionY;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && IsPlaying)
            startGame = true; //As It turns out it is most appropriate way of getting keypress Messages
        if (startGame)
            Movement(directionX, directionY);
    }

    private void Movement(bool dirX, bool dirY)
    {
        short dirValueX = -1, dirValueY = -1;
        if (dirX)
            dirValueX = 1;
        if (dirY)
            dirValueY = 1;

        transform.Translate(new Vector2(dirValueX * randDirX, dirValueY * randDirY) *
                            (ballSpeed / randDirX * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            directionX = !directionX;
            randDirY = Random.Range(0.3f, 4.3f);
        }
        else
        {
            directionY = !directionY;
            randDirX = Random.Range(0.3f, 4.3f);
        }
    }
}