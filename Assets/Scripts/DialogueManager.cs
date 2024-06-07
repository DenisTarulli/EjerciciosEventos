using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{  
    private void DisplayDialogue(string dialogue, TextMeshProUGUI text, bool hasToActivate)
    {
        if (hasToActivate)
        {
            text.gameObject.SetActive(true);
            text.text = dialogue;
        }
        else
            text.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        NPC.OnNPCInteraction += DisplayDialogue;
    }

    private void OnDisable()
    {
        NPC.OnNPCInteraction -= DisplayDialogue;
    }
}
