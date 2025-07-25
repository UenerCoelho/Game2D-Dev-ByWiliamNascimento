```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobreCargaDeMethod : MonoBehaviour
{
  // Declara uma variável do tipo calculadora
  calculadora calc;

  void Start()
  {
    // Cria uma instância da classe calculadora
    calc = new calculadora();

    // Chama o método calcula com dois inteiros
    int resultadoInt = calc.calcula(5, 10);
    // Exibe o resultado da soma de inteiros no console
    print("Resultado da soma de inteiros: " + resultadoInt);

    // Chama o método calcula com dois números de ponto flutuante
    float resultadoFloat = calc.calcula(5.5f, 10.2f);
    // Exibe o resultado da soma de inteiros no console
    print("Resultado da soma de floats: " + resultadoFloat);

  }

  void Update()
  {

  }
}

class calculadora{
  // Método para somar dois inteiros
  public int calcula(int value1, int value2){
    return value1 + value2;
  }

  // Sobrecarga do método para somar dois números de ponto flutuante
  public float calcula(float value1, float value2){
    return value1 + value2;
  }
}
```
