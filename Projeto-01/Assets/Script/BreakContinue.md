```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakContinue : MonoBehaviour
{
  string[] inimigos;
  int x=0;

  void Start()
  {
    for(int i = 0; i <= 10; i++){
      print (i);
      if(i==5){
        continue;
      }
      print (i);
      if(i==9){
        break;
      }
    }


    inimigos = new string[a];
    inimigos[0] = "Caveira";
    inimigos[1] = "Matador";
    inimigos[2] = "Atirador";
    inimigos[3] = "Mark";

    foreach(string nome in inimigos)
    {
      print(nome);
      if(nome == "matador"){
        break;
      }
      print(nome);
      if(nome == "Atirador"){
        continue;
      }
    }

  }

  void Update()
  {

  }
}
```
