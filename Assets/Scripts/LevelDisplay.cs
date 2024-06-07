using System;
using TMPro;
using UnityEngine;

public class LevelDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;

    private void Start()
    {
        LevelUIUpdate(0);
    }

    private void LevelUIUpdate(int level)
    {
        levelText.text = $"Level {level}";
    }

    private void OnEnable()
    {
        LevelManager.OnLevelChange += LevelUIUpdate;
    }

    private void OnDisable()
    {
        LevelManager.OnLevelChange -= LevelUIUpdate;
    }
}
