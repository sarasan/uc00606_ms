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
    Console.WriteLine("\n\n EXERCÍCIOS DE SET (HASHSET<T>)");
    Console.WriteLine("====================================\n");


    Console.WriteLine(" Exercício 1: HashSet com números inteiros");

    Console.WriteLine("Os números a adicionar: 10, 20, 30, 20, 40, 10, 50");


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

  Console.WriteLine($"\nQuantidade total de elementos: {numeros.Count}");
  

  Console.WriteLine(" \n===================================================");
   Console.WriteLine ("EXERCÍCIO 2: Diferença entre ExceptWith() e SymmetricExceptWith()\n");
   Console.WriteLine("\n===================================================");
   
 
        var conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };

        var conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

        Console.WriteLine("Conjunto A inicial: " + string.Join(", ", conjuntoA));

        Console.WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

        
        var aExceptw = new HashSet<int>(conjuntoA);

        aExceptw.ExceptWith(conjuntoB);

        Console.WriteLine(" ExceptWith (A - B)- Elementos em A mas não em B : " + string.Join(", ", aExceptw));

       
        var aSymmetricw = new HashSet<int>(conjuntoA);

        aSymmetricw.SymmetricExceptWith(conjuntoB);

        Console.WriteLine(" SymmetricExceptWith ((A - B) ∪ (B - A)-  Diferença simétrica): " + string.Join(", ", aSymmetricw));
    
    Console.WriteLine();

    Console.WriteLine("===================================================") ;
    Console.WriteLine("EXERCÍCIO 3: União, Interseção e Diferença entre conjuntos de pessoas");
    Console.WriteLine("===================================================");
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

        HashSet<Pessoa>equipaA = new HashSet<Pessoa>();

        HashSet<Pessoa> equipaB = new HashSet<Pessoa>();


        equipaA.Add(new Pessoa("Ana", 25));

        equipaA.Add(new Pessoa("Bruno", 30));

        equipaA.Add(new Pessoa("Carla", 35));

        equipaA.Add(new Pessoa("Daniel", 40));

        equipaB.Add(new Pessoa("Carla", 35));

        equipaB.Add(new Pessoa("Daniel", 40));

        equipaB.Add(new Pessoa("Eduarda", 40));

        equipaB.Add(new Pessoa("Fernando", 22));


        Console.WriteLine("Equipa A:");
        foreach (var p in equipaA) Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade}");
        Console.WriteLine("\nEquipa B:");
        foreach (var p in equipaB) Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade}");


        HashSet<Pessoa> uniao = new HashSet<Pessoa>(equipaA);
        uniao.UnionWith(equipaB);
        Console.WriteLine("\nUnião (A ∪ B):");
        foreach (var p in uniao) Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade}");


        HashSet<Pessoa> intersecao = new HashSet<Pessoa>(equipaA);
        intersecao.IntersectWith(equipaB);
        Console.WriteLine("\nInterseção (A ∩ B):");
        foreach (var p in intersecao) Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade}");


        HashSet<Pessoa> diferenca = new HashSet<Pessoa>(equipaA);
        diferenca.ExceptWith(equipaB);
        Console.WriteLine("\nDiferença (A - B):");
        foreach (var p in diferenca) Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade}");

   
    Console.WriteLine();

    Console.WriteLine("==================================================="); 
    Console.WriteLine("EXERCÍCIO 4: Verificar subconjunto com IsSubsetOf()");
    Console.WriteLine("==================================================="); 
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


