```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicoesIfElse : MonoBehaviour
{

  int moedasHeroi = 100;
  int valorVida = 100;

  void Start()
  {
    if (moedasHeroi == valorVida){
      print("Posso comprar a vida mas fico Zerado");
    }
    else if(moedasHeroi > valorVida){
      print("Posso comprar a vida e sobra dinheiro");
    }
    else{
      print("não tenho dinheiro!");
    }
  }

  void Update()
  {

  }
}
```
