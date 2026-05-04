namespace ExerciciosAula02;

public class ClassesMetodosListas{
 
 

  public void Executar()
  {
    Console.WriteLine("\n\n📋 3. EXERCÍCIOS DE LISTAS (LIST<T>)");
    Console.WriteLine("=====================================\n");

   Console.WriteLine("===================================================");
    Console.WriteLine("EXERCÍCIO 1: Adicionar pessoas à lista"); 
   Console.WriteLine("===================================================");



    // 1. Criar uma List<Pessoa> com os dados iniciais

    List<Pessoa> pessoas = new List<Pessoa>();
   

    // 2. Adicionar mais 3 pessoas à lista usando .Add()

     pessoas.Add(new Pessoa("Sara", 50));

     pessoas.Add(new Pessoa("Pedro",23));

     pessoas.Add(new Pessoa("Ana",23));

     pessoas.Add(new Pessoa("Sebastiao", 25));

     pessoas.Add(new Pessoa("Sean", 23));

     

     foreach( var p in pessoas)

        {
            
            Console.WriteLine($"{p}");
        }
  
    Console.WriteLine();


Console.WriteLine("EXERCÍCIO 2: Remover pessoa pelo nome");
    // ===================================================
    // 👉 O QUE FAZER:
    // 1. Usar o método RemoveAll() com uma condição (lambda)
    // 2. Remover a pessoa chamada "Ana" independente do índice
    // 3. Exibir a lista atualizada
    //
    // 💡 pessoas.RemoveAll(p => p.Nome == "Ana");
    // 💡 Lambda: p => condição (p é cada elemento da lista)

    Console.WriteLine("\n📝 Exercício 2: Remover pessoa pelo nome");

    pessoas.RemoveAll(p=>p.Nome == "Ana");

     foreach( var p in pessoas)

        {
            
            Console.WriteLine($"{p}");
        }

   Console.WriteLine("==================================================="); 
    Console.WriteLine("EXERCÍCIO 3: Filtrar pessoas com mais de 30 anos");
   Console.WriteLine("===================================================");
    // 👉 O QUE FAZER:
    // 1. Usar o método FindAll() para filtrar a lista
    // 2. Buscar todas as pessoas com idade > 30
    // 3. Exibir o resultado Console.WriteLine($".....Seu C");
    //
     List<Pessoa> filtradas = pessoas.FindAll(p => p.Idade > 30);

    // 💡 Também pode usar LINQ: pessoas.Where(p => p.Idade > 30).ToList()

    Console.WriteLine("\n📝 Exercício 3: Filtrat pessoas com mais de 30 anos");

    foreach( var p in pessoas)

        {
            
            Console.WriteLine($"{p}");
        }

    // ESCREVA SEU CÓDIGO AQUI - Filtrar pessoas com idade > 30


    //Saida esperada:
    /**📝 Exercício 3: Buscar pessoas com mais de 30 anos
    Pessoas com mais de 30 anos (3):
      - Carla (35 anos)
      - Eduarda (40 anos)
      - Gabriela (45 anos)*/
    Console.WriteLine();

  }

   }

   