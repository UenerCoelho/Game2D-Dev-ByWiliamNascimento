```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCollection : MonoBehaviour
{

  void Start()
  {
    List<int> lista = new List<int>(){
      // lista.Add (100);
      // lista.Add (200);
      // lista.Add (300);

      // lista.Remove (300);


      for(int i = 0 <= 0; i++>){
        lista.Add (i);
      }

      foreach(int valores in lista){
        print (valores);
      }
    }
  }

  void Update()
  {

  }
}
```
