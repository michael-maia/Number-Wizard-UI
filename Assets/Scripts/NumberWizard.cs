using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Necessário para a variável de tipo Text

public class NumberWizard : MonoBehaviour 
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText; //Variável criada para colocarmos o objeto GuessText dentro dela para ser exibida no jogo de acordo com o código abaixo

    int guess;  

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }    

    void StartGame()
    {
        guess = (max + min) / 2; //Primeira sugestão de número
        guessText.text = guess.ToString(); //Converte o resultado para o formato string pois assim no objeto GuessText
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess; //Muda o mínimo do nosso intervalo para ficar mais preciso o próximo "chute"
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess; //Muda o máximo do nosso intervalo para ficar mais preciso o próximo "chute"
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString(); //Atualizando o valor na tela
    }
}
