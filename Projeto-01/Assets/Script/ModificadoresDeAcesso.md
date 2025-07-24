```cs
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificadoresDeAcesso : MonoBehaviour
{
  //Objeto1
  Felino gatoFase1;
  //Objeto2
  Felino gatoFase2;

  void Start()
  {
    gatoFase1 = new Felino();
    gatoFase2 = new Felino();
    Filha if;


    // gatoFase1.nome = "Bichano";
    fi.acessa()
    gatoFase1.Atacar ();
    gatoFase1.corPelo = "rosa";
    gatoFase1.force = 100;

    // gatoFase2.nome = "Bichana";
    fi.acessa()
    gatoFase2.Atacar ();
    gatoFase2.corPelo = "azul";
    gatoFase2.force = 200;

  }

  void Update()
  {

  }
}

class Felino {
  // Características = Atributos da Classe
  protected string nome;
  public string corPelo;
  public int force;

  // Ações = Métodos da Classe
  void atacar(){

  }
}

class Filha : Felino{
  void acessa(){
    nome = "Gato";
  }
}

```
