```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementoDecremento : MonoBehaviour
{
    int carteira = 1;
    void Start()
    {
        // Incremento antes
        print(++carteira);
        print(++carteira);
        print(++carteira);
        // incremento Pós
        print(carteira++);
        print(carteira++);
        print(carteira++);
        // Decremento Antes
        print(--carteira);
        // Decremento pós
        print(carteira--);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
```
