using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    private void Start()
    {
        guess = (min + max) / 2;
        NextGuess();
    }

    public void OnPressedHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressedLower()
    {
        max = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        int min_guess = Random.Range(min, guess);
        int max_guess = Random.Range(guess, max);

        guess = (min_guess + max_guess) / 2;
        guessText.text = guess.ToString();
    }
   
}
