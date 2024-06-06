using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;

    private void HealthUpdate(float health)
    {
        healthText.text = $"Health: {health}";
    }

    private void OnEnable()
    {
        PlayerHealth.OnHealthUpdate += HealthUpdate;
    }

    private void OnDisable()
    {
        PlayerHealth.OnHealthUpdate -= HealthUpdate;        
    }
}
