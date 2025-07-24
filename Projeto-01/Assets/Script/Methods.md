```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{

  void Start()
  {
    int val;
    int val2;
    somar = new Method();
    val = somar.soma(10, 2);
    val2 = somar.soma(5, 5);


    print (val);
    print (val2);
  }

  void Update()
  {

  }
}

class Method{
  public int soma(int valor1, int valor2){
    int resultado = valor1 + valor2;

    return resultado;
  }
}
```
