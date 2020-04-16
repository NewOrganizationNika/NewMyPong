#pragma warning disable CS0649
using UnityEngine;
using UnityEngine.UI;

public class NotUISystem : MonoBehaviour
{
    private INullScore nullScore;
    [SerializeField] private Text winner;

    public void IsWinner(Player player)
    {
        winner.text = $"WINNER IS {player} {player.count}";
        nullScore.NullScore();
    }
}