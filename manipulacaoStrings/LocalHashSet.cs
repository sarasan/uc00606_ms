
using System.Security.Cryptography.X509Certificates;

namespace ExerciciosAula02;

public class LocalHashSet{
    
    // =====================================================
        // CRIANDO UM HASHSET
        // =====================================================
        // HashSet:
        // - NÃO permite elementos duplicados
        // - usa tabela hash internamente
        // - possui buscas muito rápidas
        // =====================================================




public void ExecutaHashSet()
    {
        
HashSet<Pessoa> pessoas = new HashSet<Pessoa>();

            // =====================================================
        // ADICIONANDO PESSOAS
        // =====================================================

        pessoas.Add(new Pessoa("p1",10));

        pessoas.Add(new Pessoa("p2",20));

        pessoas.Add(new Pessoa("p3",30));

        pessoas.Add(new Pessoa("p4",40));

         pessoas.Add(new Pessoa("tony",40));

        Console.WriteLine("Conjunto de Pessoa HashSet()");

        foreach(var pessoa in pessoas)
        {
            
        Console.WriteLine($"Conjunto de Pessoas {pessoa.Nome} com idade{pessoa.Idade} temos a propriedade Pessoa: {pessoa.Apresentar}");

        }
    // =========================================================
    // OVERRIDE DO EQUALS
    // =========================================================
    // Este método define QUANDO dois objetos serão iguais.
    //
    // O HashSet usa este método automaticamente
    // para verificar duplicidade.
    //
    // Neste caso:
    // Duas pessoas são iguais quando:
    // - possuem o mesmo Nome
    // - possuem a mesma Idade
    //
    // IMPORTANTE:
    // Você NÃO chama Equals() manualmente.
    // O HashSet chama automaticamente em:
    // - Add()
    // - Contains()
    // - Remove()
    // =========================================================

    bool duplicado = pessoas.Add(new Pessoa("tony", 40));

        if (!duplicado)
        {
            Console.WriteLine($"retorno da varaiavel adicionou: {duplicado}");
            Console.WriteLine("Tony Filho(40 anos) ja existe");
            Console.WriteLine("HasSet nao permite elementos duplicados");

            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Conjunto tem duplicado? {duplicado} com os dados {pessoa.Nome} com idade {pessoa.Idade}");

            
            }
        }


    // =====================================================
        // VERIFICANDO EXISTÊNCIA
        // =====================================================
        // Contains() usa:
        // - GetHashCode()
        // - Equals()
        //
        // Tudo automaticamente.
        // =====================================================

        Console.WriteLine("Verificar se existe");

        Pessoa procurarPessoa = new Pessoa("Penha", 70);


        Pessoa procurarPessoaNaoExiste = new Pessoa("Humberto", 72);

        if (pessoas.Contains(procurarPessoa))
        {
            Console.WriteLine($"**********Existe: {procurarPessoa}****");
        }
        else
        {
            Console.WriteLine($"***Nao existe****");
        }

         Console.WriteLine("\n=== RESUMO ===");
 
        Console.WriteLine("- HashSet NÃO permite duplicados");
 
        Console.WriteLine("- Equals() define igualdade");
 
        Console.WriteLine("- GetHashCode() gera o hash");
 
        Console.WriteLine("- Ambos são chamados AUTOMATICAMENTE pelo HashSet");
 
        Console.WriteLine("\nPressione qualquer tecla para sair...");

    }


}