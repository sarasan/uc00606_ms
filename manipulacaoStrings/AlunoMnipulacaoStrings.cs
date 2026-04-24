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

      string original = Console.ReadLine();

      string reversed = string.Empty;

      for(int i = original.Length -1; i>=0; i--)
    {
        reversed += original[i];
    }

    Console.WriteLine($"Original : {original}");

    Console.WriteLine($"Invertida: {reversed}");

 /*
      // ===================================================
      // EXERCÍCIO 3: Verificar palíndromo
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar uma palavra ao usuário
      // 2. Verificar se é palíndromo (lê-se igual de trás para frente)
      // 3. Comparar caractere da esquerda com caractere da direita
      // 4. Percorrer apenas até a metade da palavra
      //
      // 💡 palavra[i] != palavra[palavra.Length - 1 - i]

      Console.WriteLine("\n📝 Exercício 3: Verificação de palíndromo");
      Console.Write("Digite uma palavra: ");

      // ESCREVA SEU CÓDIGO AQUI
      //Saida
      /**� Exercício 3: Verificação de palíndromo
      Palavra: 'radar'
      É palíndromo? True*/*/

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