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

      Console.WriteLine("EXERCÍCIO 2: Inverter string ");
      
      Console.WriteLine("===============================================");

       Console.WriteLine("Insira um a frase");

      string frase2 = Console.ReadLine();

      for(int i = frase2.Length -1; i>=0; i--)
    {
      //Console.WriteLine(frase2);
      Console.WriteLine($"{frase2[i]}");
    }
    /*            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();*/


    }

    public static bool Vogal(char vg)
    {
        vg = char.ToUpper(vg);

        return (vg == 'A' || vg == 'E' || 
                vg == 'I' || vg == 'O' || 
                              vg == 'U');
    }

    public static int contaVogal(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            
            if (Vogal(str[i])) 
            {
                ++count;
            }
        }
        return count;
    }


  }