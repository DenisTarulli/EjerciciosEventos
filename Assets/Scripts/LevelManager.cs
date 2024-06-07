using System;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform[] levelsCameraPosition;
    [SerializeField] private Transform player;

    public static event Action<int> OnLevelChange;

    private int totalLevels;
    private int currentLevel;

    private void Start()
    {
        totalLevels = levelsCameraPosition.Length - 1;
        currentLevel = 0;
        UpdateCameraPosition();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && Time.timeScale != 0f)
        {
            NextLevel();
        }
    }

    private void UpdateCameraPosition()
    {
        cam.transform.position = levelsCameraPosition[currentLevel].position;
    }

    private void NextLevel()
    {
        if (currentLevel < totalLevels)
        {
            currentLevel++;
            UpdateCameraPosition();

            player.transform.position = levelsCameraPosition[currentLevel].position;

            OnLevelChange?.Invoke(currentLevel);
        }
    }
}
