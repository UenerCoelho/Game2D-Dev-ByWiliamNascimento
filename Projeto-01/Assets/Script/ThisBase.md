```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisBase : MonoBehaviour
{
  // Cria uma instância da classe pai com idade 50
  pai p;
  // Cria uma instância da classe son
  son s;

  void Start()
  {
    p = new pai(50);
    s = new son();
    // Exibe a idade do pai no console do Unity
    print("Idade do pai: " + p.idade);
    s.pegaIdade();
    // Exibe a idade do filho no console do Unity
    print("Idade do filho: " + s.idade);



  }

  void Update()
  {

  }
}

class pai{
  public int idade;

  public pai(int idade){
    this.idade = idade;
  }
}

class father{
  public int idade = 60;
}

class son : father{
  public void pegaIdade(){
    base.idade;
  }
}
```
