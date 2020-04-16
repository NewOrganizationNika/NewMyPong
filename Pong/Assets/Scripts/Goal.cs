#pragma warning disable CS0649
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] private UnityEvent isWinner, onGoal;
    [SerializeField] private Player player;
    [SerializeField] private UnityEngine.UI.Text scoreText;
    [SerializeField] private ushort score = 10;
    private void ScoreChange()
    {
        scoreText.text = player.count.ToString();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Ball")) return;
        player.count++;
        ScoreChange();
        onGoal.Invoke(); //change count and start func of ball
        if (player.count < score) return;
        isWinner.Invoke();
        Ball.IsPlaying = false;
    }
}