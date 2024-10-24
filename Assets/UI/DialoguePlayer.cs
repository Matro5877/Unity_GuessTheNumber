using UnityEngine;
using TMPro;

public class DialoguePlayer : MonoBehaviour
{

    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            dialogueLineIndex += 1;

            if (dialogueLineIndex < dialogueAsset.dialogue.Length)
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueText.gameObject.SetActive(false);
                dialogueBox.gameObject.SetActive(false);
            }

        }

    }

}
