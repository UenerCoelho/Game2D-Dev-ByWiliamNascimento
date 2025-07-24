// Início do bloco de código C#

```cs
// Importa funcionalidades básicas do .NET
using System;
// Importa funcionalidades para coleções
using System.Collections;
// Importa funcionalidades para coleções genéricas
using System.Collections.Generic;
// Importa funcionalidades do Unity
using UnityEngine;

// Define uma classe que herda de MonoBehaviour
public class CondicoesIfElse : MonoBehaviour
{


  // Quantidade de moedas do herói
  int moedasHeroi = 100;
  // Valor necessário para comprar uma vida
  int valorVida = 100;


  // Método chamado ao iniciar o script
  void Start()
  {
    // Verifica se o herói tem exatamente o valor da vida
    if (moedasHeroi == valorVida){
      // Mensagem se o herói comprar a vida e ficar sem moedas
      print("Posso comprar a vida mas fico Zerado");
    }
    // Verifica se o herói tem mais moedas que o valor da vida
    else if(moedasHeroi > valorVida){
      // Mensagem se o herói comprar a vida e sobrar moedas
      print("Posso comprar a vida e sobra dinheiro");
    }
    // Caso o herói não tenha moedas suficientes
    else{
      // Mensagem se não tiver dinheiro
      print("não tenho dinheiro!");
    }
  }


  // Método chamado a cada frame
  void Update()
  {

  }
}
```
