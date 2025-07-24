```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dicionário : MonoBehaviour
{

  void Start()
  {
    Dictionary<string.string> villain = new Dictionary<string, string> ();

    villain.Add ("Matador", "É o Primeiro Vilão.");
    villain.Add ("Atirador", "É o Segundo Vilão.");
    villain.Add ("Ladino", "É o Terceiro Vilão.");

    villain.Remove("Matador");

    foreach(string chave in villain.Keys){
      if(chave == "Atirador"){
        print (villain[chave])
      }
    }


  }

  void Update()
  {

  }
}
```
