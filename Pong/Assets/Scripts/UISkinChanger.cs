#pragma warning disable CS0649
using UnityEngine;
using UnityEngine.UI;

public class UISkinChanger : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject changeableContainer, skinContainer;
    [SerializeField] private GameObject changeableSet;

    // [SerializeField] private UnityEvent playerChanged;
    private GameObject selectedOne;

    private void Start()
    {
        for (short i = 0; i < changeableSet.transform.childCount; ++i)
        {
            var childButton = Instantiate(buttonPrefab, changeableContainer.transform);
            childButton.GetComponent<Image>().color = new Color(159, 0, 255, 40);

            var setChild = changeableSet.transform.GetChild(i);
            childButton.GetComponentInChildren<Text>().text = setChild.name;
            childButton.GetComponent<Button>().onClick
                .AddListener(() => selectedOne = setChild.gameObject);
        }

        buttonPrefab.GetComponentInChildren<Text>().text = ""; //Why Is this Line Necessary?

        selectedOne = changeableSet.transform.GetChild(0).gameObject;
        var sprites = Resources.LoadAll<Sprite>("Skins");
        foreach (var sprite in sprites)
        {
            var skinButton = Instantiate(buttonPrefab, skinContainer.transform);
            skinButton.GetComponent<Image>().sprite = sprite;
            skinButton.GetComponent<Button>().onClick.AddListener(() =>
                selectedOne.GetComponent<SpriteRenderer>().sprite = skinButton.GetComponent<Image>().sprite);
        }
    }
}