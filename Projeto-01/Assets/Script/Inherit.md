```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inherit : MonoBehaviour
{
  // Declara uma variável do tipo pai
  Pai p;
  // Declara uma variável do tipo filho
  Filho f;

  void Start()
  {

  }

  void Update()
  {

  }
}

// Classe pai
class Pai{
  // Método que retorna a idade do pai
  public int idade;
}

// Classe filho que herda de Pai
class Filho : Pai{
  // Método que retorna a idade do filho
  public int pegaIdade(){
    // Chama o método idade da classe pai
    base.idade;
  }
}
```
