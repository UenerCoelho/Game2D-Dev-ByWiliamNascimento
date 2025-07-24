```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructors : MonoBehaviour
{
  method obj;

  void Start()
  {
  obj = new methods(20, "Oi Pessoal");
  print(obj.valor1);
  print(obj.valor2);

  }

  void Update()
  {

  }
}

class methods(){
  public int valor1;
  public string valor2;

  public methods(int valor, string value){
    this.valor1 = valor;
    this.valor2 = value;
  }
}
```
