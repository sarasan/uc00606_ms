namespace ExerciciosAula02;

public class ClassesMetodosListas{
 
 

  public void Executar()
  {
    Console.WriteLine("\n\n📋 3. EXERCÍCIOS DE LISTAS (LIST<T>)");
    Console.WriteLine("=====================================\n");

    // ===================================================
    // EXERCÍCIO 1: Adicionar pessoas à lista
    // ===================================================
    // 👉 O QUE FAZER:

  

    // 3. Exibir todas as pessoas da lista
    //
    // 💡 List<T> é uma coleção dinâmica que pode crescer
    // 💡 pessoas.Add(new Pessoa("Nome", idade));

    Console.WriteLine("📝 Exercício 1: Adicionar pessoas à lista");

    // 1. Criar uma List<Pessoa> com os dados iniciais
    List<Pessoa> pessoas = new List<Pessoa>();

    // 2. Adicionar mais 3 pessoas à lista usando .Add()

     pessoas.Add(new Pessoa("Sara", 50));

     pessoas.Add(new Pessoa("Pedro",23));

     pessoas.Add(new Pessoa("Ana",23));

     pessoas.Add(new Pessoa("Sebastiao", 25));

     pessoas.Add(new Pessoa("Sean", 23));

     

     foreach(  var p in pessoas)

        {
            
            Console.WriteLine($"{p}");
        }
  


    //Saida esperada:
    /**📝 Exercício 1: Adicionar pessoas à lista
    Lista inicial:
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)

    Lista após adicionar 3 pessoas:
      - Ana (25 anos)
      - Bruno (30 anos)
      - Carla (35 anos)
      - Daniel (28 anos)
      - Eduarda (40 anos)
      - Fernando (22 anos)
      - Gabriela (45 anos)
      - Hugo (33 anos)*/
    Console.WriteLine();
  }
   }