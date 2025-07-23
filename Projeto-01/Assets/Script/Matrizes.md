```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrizes : MonoBehaviour
{

  void Start()
  {
    int[,] matriz = new int[2,2];

    // matriz [0,0] = 1;
    // matriz [0,1] = 2;
    // matriz [1,0] = 3;
    // matriz [1,1] = 3;

    for(int linhas = 0; linha <= 1; linhas++){
      for(int colunas = 0; colunas <= 1; colunas++){
        matriz [linhas, colunas] = valor;
        valor++;
      }
    }

    for(int linhas = 0; linha <= 1; linhas++){
      for(int colunas = 0; colunas <= 1; colunas++){
        print("Na "+linhas+" e Coluna "+colunas+" Tenho o Valor: "+matriz[linhas,colunas]);
      }
    }
  }

  void Update()
  {

  }
}
```
