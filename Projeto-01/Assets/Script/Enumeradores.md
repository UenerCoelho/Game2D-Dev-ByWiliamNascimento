```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeradores : MonoBehaviour
{
  enum AI{Atacar, Correr, Patrulhar};

  void Start()
  {
    AI villainFase1 = AI.Patrulhar;
    AI villainFase2 = AI.Correr;
    AI villainFase3 = AI.Atacar;

    int v1 = (int)villainFase1

    print(v1);

    print(villainFase3);
  }

  void Update()
  {

  }
}
```
