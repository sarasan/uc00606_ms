using System.ComponentModel;
using System.Globalization;

namespace ExerciciosAula02;

public class AlunoFuncoesMetodos
  {
    public void Executar()
    {
      Console.WriteLine("\n\n  EXERCÍCIOS DE FUNÇÕES E MÉTODOS");

      Console.WriteLine("==========================================\n");

      Console.WriteLine("===============================================");

      Console.WriteLine("EXERCÍCIO 1: Fatorial\n");
      
      Console.WriteLine("===============================================");

        
        Console.WriteLine("Insira um numero para calcular o factorial: \n");

        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(num);

        Console.Write($"O Factorial de : {num} =  {factorial}\n");   

            

/////////////////////////////////////////////////////////////////
    
       Console.WriteLine("EXERCÍCIO 2: Números primos\n");
      
       Console.WriteLine("===============================================");

        Console.WriteLine("Insira um numero para verificar se e primo:\n ");

        int numb = Convert.ToInt32(Console.ReadLine());

        bool primo = VerificarPrimo(numb);

        Console.WriteLine($"{numb} primo? {primo}");

        ///////////////////////////////////////
        
       Console.WriteLine("EXERCÍCIO 3: Função com parâmetros opcionais\n");
      
       Console.WriteLine("===============================================");

       string nome = "ana";

       SaudacaoPersonalizada(nome);

       nome = "Bruno";

       bool formal =true;

       SaudacaoPersonalizada(nome, formal);





      

  
    }

  
    


    public static long CalcularFactorial(int n) {
        
        // Calculating factorial of number
        long factorial = 1;

        for (int i = 2; i <= n; i++) {

            factorial = factorial * i;
        }

        return factorial;
    }

public static bool VerificarPrimo(int num)

{
    if (num <= 1) return false; 


    if (num == 2) return true; 


   for(int i = 2; i*i <= num; i++) 

        if (num % i == 0) return false; 

    return true;
}

public static  void SaudacaoPersonalizada(string nome = "Visitante", bool formal = false)

{
     if (formal == true) {
     
     Console.WriteLine($"Prezado(a) {nome}, seja bem-vindo(a)\n");
     }

     else{
     
     Console.WriteLine($"Olá {nome}! Bem-vindo(a)\n!");
     }
      
}
  }


  