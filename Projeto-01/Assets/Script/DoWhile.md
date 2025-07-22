```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
  int x = 0;
  void Start()
  {
    do{
      print(x);
      x++;
    }while(x <= 10);
  }

  void Update()
  {

  }
}
```
