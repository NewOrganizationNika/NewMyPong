using UnityEngine;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu = null, shop = null, scoreCanvas = null, playerVsNPC = null;

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

    public void ChangePlayMode()
    {
        menu.SetActive(false);
        playerVsNPC.SetActive(true);
    }

    public void MainMenu()
    {
        menu.SetActive(true);
        shop.SetActive(false);
        playerVsNPC.SetActive(false);
        scoreCanvas.SetActive(false);
    }
}