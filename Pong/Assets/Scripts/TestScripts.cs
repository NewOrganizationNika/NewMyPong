#pragma warning disable CS0649
using UnityEngine;
using UnityEngine.UI;

public class TestScripts : MonoBehaviour
{
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(() => Debug.Log("HI"));
    }
}