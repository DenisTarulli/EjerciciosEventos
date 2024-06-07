using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private string dialogue;
    [SerializeField] private TextMeshProUGUI dialogueTextBox;

    public static event Action<string, TextMeshProUGUI, bool> OnNPCInteraction;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        OnNPCInteraction?.Invoke(dialogue, dialogueTextBox, true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        OnNPCInteraction?.Invoke(dialogue, dialogueTextBox, false);
    }
}
