```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulamento : MonoBehaviour
{
  Pai p = new Pai();

  void Start()
  {
    p.Idade = 50; // Acessando o setter
    print(pai.Idade); // Acessando o getter
  }

  void Update()
  {

  }
}

class Pai
{
  // Atributo
  private int idade = 10;

  // Construtor
  public int Idade
  {
    get { return idade; } // Getter para acessar o valor de idade
    // Setter para definir o valor de idade com validação
    set { if (value > 10){
      idade = value;
      } else {
        print("Idade inválida!");
        }
    }
  }
}
```
