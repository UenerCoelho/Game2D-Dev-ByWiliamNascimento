using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    int moedas;
    float dinheiro = 10.2f;
    bool duvida = false;
    string texto = "texto aqui";
    // Start is called before the first frame update
    void Start()
    {
        moedas = 100;
        Debug.Log(moedas);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
