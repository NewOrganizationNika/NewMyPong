using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerVsNPC : MonoBehaviour
{
    private readonly List<GameObject> players = new List<GameObject>();
    private void Awake()
    {
        players.Clear();
        foreach (var basicAI in GetComponentsInChildren<BasicAI>())
        {
            players.Add(basicAI.gameObject);
        }

    }

    public void PlayerVsPlayer()
    {
        foreach (var player in players)
        {
            player.GetComponent<BasicAI>().enabled = false;
        }
    }

    public void PlayerVsNPC()
    {
        players[0].GetComponent<BasicAI>().enabled = false;
        players[1].GetComponent<BasicAI>().enabled = true;
    }

    public void NPCVsNPC()
    {
        foreach (var player in players)
        {
            player.GetComponent<BasicAI>().enabled = true;
        }
    }
}
