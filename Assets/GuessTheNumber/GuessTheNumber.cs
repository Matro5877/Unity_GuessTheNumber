using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text))
        {
            messageText.text = "plz écrire un numéro ou no bobux";
            numberInput.text = "";
            return;
        }

        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "gg ez";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "trop haut calme toi";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "trop bas bebou";
            }
        }
        else
        {
            messageText.text = "plz écrire un numéro entre 1 et 99 ou no bobux";
        }

        numberInput.text = "";

    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100);
        Debug.Log("Generated number: " + randomNumber);
        messageText.text = "Freaky Simulator";
    }

}
