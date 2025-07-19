```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoreAritmeticos : MonoBehaviour
{
  int num1, num2, num3, resultado1, resultado2, resultado3, resultado4, resultado5, resultado6;

  void Start()
  {
    num1 = 10;
    num2 = 20;
    num3 = 2;

    resultado1 = (num1 + num2) * num3;
    print(resultado1);
    resultado2 = num2 / num3;
    print(resultado2);
    resultado3 = num1 * num2;
    print(resultado3);
    resultado4 = num1 - num2;
    print(resultado4);
    resultado5 = num1 % num2;
    print(resultado5);
    resultado6 = num1 - num2;
    print(resultado6);
  }


  void Update()
  {

  }
}
```
