```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Switch : MonoBehaviour
{

  // Estado = 1 (Coragem)
  // Estado = 2 (Meio-termo)
  // Estado = 3 (Covarde)
  int estados = 3;

  void Start()
  {
    // if (estados == 1){
    //   print ("mate o Heroi!");
    // }else if(estados == 2){
    //   print("mate se puder!");
    // }else if(estados == 3){
    //   print("Corra agora!");
    // }else{
    //   print("Nenhum estado seleciona");
    // }
    switch (estados){
      case 1:
      print ("mate o HerÓi!");
      case 2:
      print("mate se puder!");
      case 3:
      print("Corra agora!");
      default:
      print("Nenhum estado seleciona");
    }

  }

  void Update()
  {

  }
}
```
