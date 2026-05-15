namespace ExerciciosAula02;
public class AlunoExercicio04
{
 
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }

    public override string ToString()
    {
      return $"{Nome} ({Idade} anos)";
    }

    // Necessário para HashSet comparar corretamente os objetos
    public override bool Equals(object obj)
    {
      if (obj is Pessoa outra)
        return Nome == outra.Nome && Idade == outra.Idade;
      return false;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(Nome, Idade);
    }
  }

  public void Executar()
  {
    Console.WriteLine("\n\n🎯 4. EXERCÍCIOS DE SET (HASHSET<T>)");
    Console.WriteLine("====================================\n");

    // ===================================================
    // EXERCÍCIO 1: HashSet com números inteiros e repetidos
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar um HashSet<int> chamado numeros
    // 2. Adicionar os números: 10, 20, 30, 20, 40, 10, 50
    // 3. Exibir todos os elementos (observar que repetidos não entram)
    // 4. Exibir a quantidade total de elementos
    //
    // 💡 HashSet não permite elementos duplicados
    // 💡 O método Add() retorna false se o elemento já existe

    Console.WriteLine("📝 Exercício 1: HashSet com números inteiros");
    Console.WriteLine("Os números a adicionar: 10, 20, 30, 20, 40, 10, 50");

    // ESCREVA SEU CÓDIGO AQUI

    //Saida esperada:
    /**📝 Exercício 1: HashSet com números inteiros
    Os números a adicionar: 10, 20, 30, 20, 40, 10, 50

    Resultado das adições:
      10 adicionado? True
      20 adicionado? True
      30 adicionado? True
      20 (2ª vez) adicionado? False
      40 adicionado? True
      10 (2ª vez) adicionado? False
      50 adicionado? True

    Elementos no HashSet: 10, 20, 30, 40, 50
    Quantidade de elementos: 5*/

    Console.WriteLine();

    HashSet<int> numeros = new HashSet<int>();

     int[] valores = { 10, 20, 30, 20, 40, 10, 50 };

     foreach (int v in valores)
     {
     bool adicionado = numeros.Add(v);

     Console.WriteLine($"Adicionado {v}: {(adicionado ? true :  false)}");
  }

  Console.WriteLine("\nElementos do HashSet:");

  foreach (int n in numeros)
  {
  Console.WriteLine(n);
  }

  // 4. Exibir a quantidade total de elementos
  Console.WriteLine($"\nQuantidade total de elementos: {numeros.Count}");
  

    // ===================================================
    // EXERCÍCIO 2: Diferença entre ExceptWith() e SymmetricExceptWith()
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar dois HashSets: conjuntoA = {1, 2, 3, 4, 5} e conjuntoB = {4, 5, 6, 7, 8}
    // 2. Mostrar ExceptWith() - remove do conjuntoA os elementos que estão em conjuntoB
    // 3. Mostrar SymmetricExceptWith() - remove os elementos que estão em ambos (diferença simétrica)
    //
    // 💡 ExceptWith() = A - B (elementos que estão em A mas não em B)
    // 💡 SymmetricExceptWith() = (A - B) ∪ (B - A) (elementos que estão em A ou B, mas não em ambos)

    Console.WriteLine("\n📝 Exercício 2: Diferença entre ExceptWith() e SymmetricExceptWith()");

    // ESCREVA SEU CÓDIGO AQUI
  ////  ///////////////////////////
 
        var conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };

        var conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

        Console.WriteLine("Conjunto A inicial: " + string.Join(", ", conjuntoA));

        Console.WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

        
        var aExceptw = new HashSet<int>(conjuntoA);

        aExceptw.ExceptWith(conjuntoB);

        Console.WriteLine(" ExceptWith (A - B): " + string.Join(", ", aExceptw));

       
        var aSymmetricw = new HashSet<int>(conjuntoA);

        aSymmetricw.SymmetricExceptWith(conjuntoB);

        Console.WriteLine(" SymmetricExceptWith ((A - B) ∪ (B - A)): " + string.Join(", ", aSymmetricw));
    




    //Saida esperada:
    /**📝 Exercício 2: Diferença entre ExceptWith() e SymmetricExceptWith()
    Conjunto A original: 1, 2, 3, 4, 5
    Conjunto B original: 4, 5, 6, 7, 8

    ExceptWith() - Elementos em A mas não em B: 1, 2, 3
    SymmetricExceptWith() - Diferença simétrica: 1, 2, 3, 6, 7, 8*/
    Console.WriteLine();

    // ===================================================
    // EXERCÍCIO 3: União, Interseção e Diferença entre conjuntos de pessoas
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar HashSet<Pessoa> para equipeA e equipeB
    // 2. Adicionar pessoas em cada equipe
    // 3. Realizar operações:
    //    - UnionWith() → união
    //    - IntersectWith() → interseção
    //    - ExceptWith() → diferença
    //
    // 💡 UnionWith() = A ∪ B (todos os elementos de A e B)
    // 💡 IntersectWith() = A ∩ B (elementos que estão em ambos)
    // 💡 ExceptWith() = A - B (elementos em A que não estão em B)

    Console.WriteLine("\n📝 Exercício 3: Operações com conjuntos de pessoas");

    // ESCREVA SEU CÓDIGO AQUI

/*using System;
using System.Collections.Generic;

record Pessoa(string Nome, int Id); // record fornece igualdade por valor (Nome+Id)

class Program
{
    static void Main()
    {
        // 1. Criar HashSet<Pessoa> para equipeA e equipeB
        var equipeA = new HashSet<Pessoa>();
        var equipeB = new HashSet<Pessoa>();

        // 2. Adicionar pessoas em cada equipe
        var p1 = new Pessoa("Ana", 1);
        var p2 = new Pessoa("Bruno", 2);
        var p3 = new Pessoa("Carla", 3);
        var p4 = new Pessoa("Daniel", 4);
        var p5 = new Pessoa("Eva", 5);

        // equipeA: Ana, Bruno, Carla
        equipeA.Add(p1);
        equipeA.Add(p2);
        equipeA.Add(p3);

        // equipeB: Carla, Daniel, Eva
        equipeB.Add(p3); // mesma instância ou mesmo valor — igualidade do record garante unicidade
        equipeB.Add(p4);
        equipeB.Add(p5);

        // Exibir conteúdos iniciais
        Console.WriteLine("Equipe A:");
        foreach (var p in equipeA) Console.WriteLine($"- {p.Nome} (Id {p.Id})");
        Console.WriteLine("\nEquipe B:");
        foreach (var p in equipeB) Console.WriteLine($"- {p.Nome} (Id {p.Id})");

        // 3a. União: A ∪ B (não modificar originais — criar cópia)
        var uniao = new HashSet<Pessoa>(equipeA);
        uniao.UnionWith(equipeB);
        Console.WriteLine("\nUnião (A ∪ B):");
        foreach (var p in uniao) Console.WriteLine($"- {p.Nome} (Id {p.Id})");

        // 3b. Interseção: A ∩ B (pessoas em ambos)
        var intersecao = new HashSet<Pessoa>(equipeA);
        intersecao.IntersectWith(equipeB);
        Console.WriteLine("\nInterseção (A ∩ B):");
        foreach (var p in intersecao) Console.WriteLine($"- {p.Nome} (Id {p.Id})");

        // 3c. Diferença: A - B (em A que não estão em B)
        var diferenca = new HashSet<Pessoa>(equipeA);
        diferenca.ExceptWith(equipeB);
        Console.WriteLine("\nDiferença (A - B):");
        foreach (var p in diferenca) Console.WriteLine($"- {p.Nome} (Id {p.Id})");

        // Observação: HashSet usa igualdade (Equals/GetHashCode). 'record' já implementa por valor.
    }
}
*/

    //Saida esperada:
    /**📝 Exercício 3: Operações com conjuntos de pessoas

    Equipe A:
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)

    Equipe B:
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)

    União (EquipeA ∪ EquipeB):
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)

    Interseção (EquipeA ∩ EquipeB):
      - Carla (35 anos)
      - Daniel (28 anos)

    Diferença (EquipeA - EquipeB):
      - Ana (25 anos)
      - Bruno (30 anos)*/
    Console.WriteLine();

    // ===================================================
    // EXERCÍCIO 4: Verificar subconjunto com IsSubsetOf()
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Criar dois conjuntos: conjuntoPrincipal e conjuntoSub
    // 2. Verificar se conjuntoSub é subconjunto de conjuntoPrincipal
    // 3. Verificar se conjuntoSub2 é subconjunto de conjuntoPrincipal
    // 4. Usar IsSubsetOf() e IsSupersetOf()
    //
    // 💡 IsSubsetOf() → verifica se todos os elementos de um conjunto estão em outro
    // 💡 IsSupersetOf() → verifica se um conjunto contém todos os elementos de outro

    Console.WriteLine("\n📝 Exercício 4: Verificar subconjunto com IsSubsetOf()");

    // ESCREVA SEU CÓDIGO AQUI

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Criar dois conjuntos: conjuntoPrincipal e conjuntoSub
        var conjuntoPrincipal = new HashSet<int> { 1, 2, 3, 4, 5 };
        var conjuntoSub = new HashSet<int> { 2, 4 };
        var conjuntoSub2 = new HashSet<int> { 2, 6 }; // contém elemento que não está em conjuntoPrincipal

        // 2. Verificar se conjuntoSub é subconjunto de conjuntoPrincipal
        bool subEhSubconjunto = conjuntoSub.IsSubsetOf(conjuntoPrincipal);
        Console.WriteLine($"conjuntoSub é subconjunto de conjuntoPrincipal? {subEhSubconjunto}");

        // 3. Verificar se conjuntoSub2 é subconjunto de conjuntoPrincipal
        bool sub2EhSubconjunto = conjuntoSub2.IsSubsetOf(conjuntoPrincipal);
        Console.WriteLine($"conjuntoSub2 é subconjunto de conjuntoPrincipal? {sub2EhSubconjunto}");

        // 4. Usar IsSubsetOf() e IsSupersetOf()
        // IsSupersetOf(): true se conjuntoPrincipal contém todos os elementos do conjuntoSub
        bool principalEhSuper = conjuntoPrincipal.IsSupersetOf(conjuntoSub);
        Console.WriteLine($"conjuntoPrincipal é superset de conjuntoSub? {principalEhSuper}");

        bool principalEhSuper2 = conjuntoPrincipal.IsSupersetOf(conjuntoSub2);
        Console.WriteLine($"conjuntoPrincipal é superset de conjuntoSub2? {principalEhSuper2}");
    }
}
*/

    //Saida esperada:
    /**📝 Exercício 4: Verificar subconjunto com IsSubsetOf()
    Conjunto Principal: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    Conjunto Sub1: 2, 4, 6, 8
    Conjunto Sub2: 2, 4, 6, 8, 11

    ConjuntoSub1 é subconjunto do Principal? True
    ConjuntoSub2 é subconjunto do Principal? False
    ConjuntoPrincipal é superconjunto do Sub1? True*/
    Console.WriteLine();

    // ===================================================
    // RESUMO FINAL
    // ===================================================
    /*Console.WriteLine("\n📌 Resumo sobre HashSet<T>:");
    Console.WriteLine("new HashSet<T>()              → criar conjunto vazio");
    Console.WriteLine("hashSet.Add(item)             → adicionar item (retorna bool)");
    Console.WriteLine("hashSet.UnionWith(outro)      → união (A ∪ B)");
    Console.WriteLine("hashSet.IntersectWith(outro)  → interseção (A ∩ B)");
    Console.WriteLine("hashSet.ExceptWith(outro)     → diferença (A - B)");
    Console.WriteLine("hashSet.SymmetricExceptWith(outro) → diferença simétrica");
    Console.WriteLine("hashSet.IsSubsetOf(outro)     → verificar se é subconjunto");
    Console.WriteLine("hashSet.IsSupersetOf(outro)   → verificar se é superconjunto");
    Console.WriteLine("hashSet.Count                → quantidade de elementos");*/
  }
}

