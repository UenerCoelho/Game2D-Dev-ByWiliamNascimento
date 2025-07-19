```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresTernarios : MonoBehaviour
{

  int moedasHeroi = 100;
  int valorVida = 100;
  string result;

  void Start()
  {

    result = (moedasHeroi >= valorVida)? "Posso comprar a vida!" : "não tenho dinheiro!";

    print (result);
  }

  void Update()
  {

  }
}
```
