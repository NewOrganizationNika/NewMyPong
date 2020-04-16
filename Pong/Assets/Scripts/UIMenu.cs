#pragma warning disable CS0649
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu, shop, scoreCanvas;

    public void StartPlaying()
    {
        menu.SetActive(false);
        scoreCanvas.SetActive(true);
        Ball.IsPlaying = true;
    }

    public void Shopping()
    {
        menu.SetActive(false);
        shop.SetActive(true);
    }

    public void MainMenu()
    {
        menu.SetActive(true);
        shop.SetActive(false);
        scoreCanvas.SetActive(false);
    }
}