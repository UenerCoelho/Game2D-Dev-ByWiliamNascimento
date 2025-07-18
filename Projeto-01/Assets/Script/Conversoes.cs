using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversoes : MonoBehaviour
{

  int carteira = 100;
  float carteira2 = 10.5f;
  int testeConvert;
  bool teste = true;
  string texto;

  void Start()
  {
    carteira = (int)carteira2;
    print(carteira);

    testeConvert = Convert.ToInt32(teste);
    print(testeConvert);

    texto = carteira.ToString();
    print(texto + 1);
  }

  void Update()
  {

  }
}