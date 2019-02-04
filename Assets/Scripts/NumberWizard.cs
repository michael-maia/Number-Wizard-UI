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
        NextGuess();
        
    }

    public void OnPressHigher()
    {
        //Muda o mínimo do nosso intervalo para ficar mais preciso o próximo palpite
        min = guess + 1; //O +1 serve para que o computador não use os palpites na próxima escolha
        NextGuess();
    }

    public void OnPressLower()
    {
        //Muda o máximo do nosso intervalo para ficar mais preciso o próximo palpite
        max = guess - 1; //O -1 serve para que o computador não use os palpites na próxima escolha
        NextGuess();
    }

    void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1); //Gerador de números aleatórios
        guessText.text = guess.ToString();  //Converte o resultado para string pois o GuessText é uma string               
    }
}
