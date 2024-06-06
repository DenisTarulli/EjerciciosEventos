using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private readonly List<string> items = new();

    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI ballsText;
    [SerializeField] private TextMeshProUGUI appleText;

    private int coinsAmount;
    private int ballsAmount;
    private int applesAmount;

    public void AddItem(string item)
    {
        items.Add(item);

        UpdateUI();
    }

    public void UpdateUI()
    {
        coinsAmount = 0;
        ballsAmount = 0;
        applesAmount = 0;

        foreach (string item in items)
        {
            if (item == "Coin")
                coinsAmount++;
            else if (item == "Ball")
                ballsAmount++;
            else
                applesAmount++;
        }

        coinsText.text = $"x{coinsAmount:D2}";
        ballsText.text = $"x{ballsAmount:D2}";
        appleText.text = $"x{applesAmount:D2}";
    }

    private void OnEnable()
    {
        Collectible.OnItemCollected += AddItem;
    }

    private void OnDisable()
    {
        Collectible.OnItemCollected -= AddItem;        
    }
}
