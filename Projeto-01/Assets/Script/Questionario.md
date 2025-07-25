Questionário 01

1.  Crie variáveis para representar os seguintes itens:

a. Número de vidas

```csharp
  int vidas = 3;
```

b. Número de moedas

```csharp
  int moedas = 10;
```

c. Nome

```csharp
  string nome = "Jogador1";
```

d. Energia

```csharp
  float energia = 100.0f;
```

2.  Faça uma soma usando os valores inteiros de duas variáveis (valor1 e valor2), coloque o resultado em uma terceira variável (result) e exiba no console seu resultado.

```csharp
  using UnityEngine;
  public class SomaExemplo : MonoBehaviour
  {
    // Declaração das variáveis
    // valor1 e valor2 para armazenar os números a serem somados
    int valor1 = 5;
    int valor2 = 10;
    // result para armazenar o resultado da soma
    int result = valor1 + valor2;
    // Método Start é chamado ao iniciar o script
    // Aqui, exibimos o resultado da soma no console
    void Start()
    {
      // Exibe o resultado da soma no console
    print("Resultado da soma: " + result);
    }
    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Não há lógica aqui, mas poderia ser usado para atualizações contínuas
    }
}
```

3.  Crie uma estrutura condicional que exibe a palavra Unity se, e somente se a variável inteira (engine) for maior que 10.

```csharp
  using UnityEngine;
  public class CondicionalExemplo : MonoBehaviour
  {
    // Declaração da variável inteira 'engine'
    int engine = 15;
    void Start()
    {
      if (engine > 10)
      {
        print("Unity");
      }
    }
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }
```

4.  Crie um laço de qualquer tipo que seja capaz de imprimir no console números de 0 (zero) até 10.

```csharp
  using UnityEngine;
  public class LacoExemplo : MonoBehaviour
  {
    // Método Start é chamado ao iniciar o script
    // Aqui, usamos um laço for para imprimir números de 0 a 10
    void Start()
    {
      // Laço for que itera de 0 a 10
      // 'i' é a variável de controle do laço
      for (int i = 0; i <= 10; i++)
      {
        print("Número: " + i);
      }
    }
    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }
```

5.  Crie um vetor para guardar 5 nomes de vilões, depois imprima no console cada um dos nomes.

```csharp
  using UnityEngine;
  public class VetorExemplo : MonoBehaviour
  {
    // Declaração do vetor de strings para armazenar os nomes dos vilões
    string[] villains = new string[5] { "Vilão1", "Vilão2", "Vilão3", "Vilão4", "Vilão5" };

    // Método Start é chamado ao iniciar o script
    void Start()
    {
      // Laço for para iterar sobre o vetor e imprimir cada nome no console
      for (int i = 0; i < villains.Length; i++)
      {
        print("Nome do Vilão: " + villains[i]);
      }
    }

    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }
```

6.  Crie uma lista contendo 10 elementos de qualquer tipo depois imprima cada elemento no console.

```csharp
  using UnityEngine;
  using System.Collections.Generic;

  public class ListaExemplo : MonoBehaviour
  {
    // Declaração da lista de strings para armazenar os elementos
    List<string> elementos = new List<string> { "Elemento1", "Elemento2", "Elemento3", "Elemento4", "Elemento5", "Elemento6", "Elemento7", "Elemento8", "Elemento9", "Elemento10" };

    // Método Start é chamado ao iniciar o script
    void Start()
    {
      // Laço foreach para iterar sobre a lista e imprimir cada elemento no console
      foreach (string elemento in elementos)
      {
        print("Elemento: " + elemento);
      }
    }

    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }
```

7.  Crie uma classe que represente um zumbi, todos seus atributos devem ser públicos.

```csharp
  using UnityEngine;

  public class Zumbi : MonoBehaviour
  {


    // Método Start é chamado ao iniciar o script
    void Start()
    {
      Zumbi zumbi = new Zumbi("Zumbi Comum", 100, 2.5f, true);
      print("Nome: " + zumbi.nome);
      print("Vida: " + zumbi.vida);
      print("Velocidade: " + zumbi.velocidade);
      print("Está Vivo: " + zumbi.estaVivo);
    }

    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }

  class Zumbi
  {
    // Atributos públicos do zumbi
    public string nome;
    public int vida;
    public float velocidade;
    public bool estaVivo;

    // Construtor para inicializar os atributos
    public Zumbi(string nome, int vida, float velocidade, bool estaVivo)
    {
      this.nome = nome;
      this.vida = vida;
      this.velocidade = velocidade;
      this.estaVivo = estaVivo;
    }
  }
```

8.  Crie um objeto da classe zumbi e exiba no console cada atributo criado.

```csharp
  using UnityEngine;

  public class ZumbiExemplo : MonoBehaviour
  {
    // Método Start é chamado ao iniciar o script
    void Start()
    {
      // Criação de um objeto da classe Zumbi
      Zumbi zumbi = new Zumbi("Zumbi Comum", 100, 2.5f, true);
      // Exibição dos atributos do zumbi no console
      print("Nome: " + zumbi.nome);
      print("Vida: " + zumbi.vida);
      print("Velocidade: " + zumbi.velocidade);
      print("Está Vivo: " + zumbi.estaVivo);
    }

    // Método Update é chamado a cada frame, mas não é usado aqui
    void Update()
    {
      // Método Update não é usado aqui, mas poderia ser usado para atualizações contínuas
    }
  }
class Zumbi
  {
    // Atributos públicos do zumbi
    public string nome;
    public int vida;
    public float velocidade;
    public bool estaVivo;

    // Construtor para inicializar os atributos
    public Zumbi(string nome, int vida, float velocidade, bool estaVivo)
    {
      this.nome = nome;
      this.vida = vida;
      this.velocidade = velocidade;
      this.estaVivo = estaVivo;
    }
  }
```

9.  Crie uma classe chamada zumbi_filho e faça com que ela herde da classe zumbi.

```csharp
  using UnityEngine;

  class ZumbiFilho : Zumbi
  {
    // Construtor da classe ZumbiFilho
    public ZumbiFilho(string nome, int vida, float velocidade, bool estaVivo) : base(nome, vida, velocidade, estaVivo)
    {
    }

    // Método que sobrescreve o método andar da classe pai
    public override void andar()
    {
      print("Zumbi Filho está andando.");
    }
  }

10. Usando polimorfismo crie um método chamado andar, dentro da classe zumbi_filho e zumbi, garanta que seremos capazes de sobrescrever esse método.
```

```csharp
  using UnityEngine;

  class Zumbi : MonoBehaviour
  {
    // Método que pode ser sobrescrito
    public virtual void andar()
    {
      print("Zumbi está andando.");
    }
  }
  class ZumbiFilho : Zumbi
  {
    // Construtor da classe ZumbiFilho
    public ZumbiFilho(string nome, int vida, float velocidade, bool estaVivo) : base(nome, vida, velocidade, estaVivo)
    {
    }

    // Método que sobrescreve o método andar da classe pai
    public override void andar()
    {
      print("Zumbi Filho está andando.");
    }
  }
```
