using System;

namespace ExerciciosAula02;


public class AlunoManipulacaoStrings
  {
    public void Executar()
    {
      Console.WriteLine("\n\n EXERCÍCIOS DE MANIPULAÇÃO DE STRINGS");

      Console.WriteLine("==========================================\n");

      Console.WriteLine("===============================================");

      Console.WriteLine("EXERCÍCIO 1: Contar vogais");
      
      Console.WriteLine("===============================================");

      Console.WriteLine("Insira um a frase");

      string frase = Console.ReadLine();

      Console.WriteLine(contaVogal(frase));


      Console.WriteLine("==========================================\n");

      Console.WriteLine("===============================================");

      Console.WriteLine("EXERCÍCIO 2: Contar vogais");
      
      Console.WriteLine("===============================================");


    }

    public static bool Vogal(char vg)
    {
        vg = char.ToUpper(vg);

        return (vg == 'A' || vg == 'E' || 
                vg == 'I' || vg == 'O' || 
                              vg == 'U');
    }

    // Returns count of vowels in str 
    public static int contaVogal(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            
            // Check for vowel
            if (Vogal(str[i])) 
            {
                ++count;
            }
        }
        return count;
    }


  }