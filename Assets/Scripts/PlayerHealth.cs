using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float healthDecrease;
    [SerializeField] private float healthIncrease;
    private float currentHealth;

    public static event Action<float> OnHealthUpdate;

    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthUpdate?.Invoke(currentHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && Time.timeScale != 0)
        {
            currentHealth -= healthDecrease;

            if (currentHealth < 0f)
                currentHealth = 0f;

            OnHealthUpdate?.Invoke(currentHealth);
        }

        if (Input.GetKeyDown(KeyCode.K) && Time.timeScale != 0)
        {
            currentHealth += healthIncrease;

            OnHealthUpdate?.Invoke(currentHealth);
        }
    }
}
