```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polimorfismo : MonoBehaviour
{
  // Declaração de objetos de tipos diferentes que herdam da classe 'animal'
  lion leo = new lion();
  gato cat = new gato();

  void Start()
  {
    // Chama o método 'comer' do objeto 'leo'
    leo.comer();
    // Chama o método 'comer' do objeto 'cat'
    cat.comer();

  }

  void Update()
  {

  }
}

class animal : MonoBehaviour{
  public virtual void comer(){
    print("Animal comendo");
  }
}



class lion : animal{
  public override void comer(){
    print("Leão comendo");
  }
}

class gato : animal{
  public override void comer(){
    print("Gato comendo");
  }
}
```
