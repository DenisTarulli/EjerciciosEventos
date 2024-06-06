using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private string itemName;

    public static event Action<string> OnItemCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        OnItemCollected?.Invoke(itemName);
        Destroy(gameObject);
    }
}
