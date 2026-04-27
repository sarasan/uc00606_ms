namespace ExerciciosAula02;

public class AlunoFuncoesMetodos
  {
    public void Executar()
    {
      Console.WriteLine("\n\n  EXERCÍCIOS DE FUNÇÕES E MÉTODOS");

      Console.WriteLine("==========================================\n");

      Console.WriteLine("===============================================");

      Console.WriteLine("EXERCÍCIO 1: Fatorial");
      
      Console.WriteLine("===============================================");

        
        Console.WriteLine("Insira um numero para calcular o factorial: ");

        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(num);

        Console.Write($"O Factorial de : {num} =  {factorial}\n");   

            

/////////////////////////////////////////////////////////////////
    
      Console.WriteLine("EXERCÍCIO 2: Números primos");
      
      Console.WriteLine("===============================================");

        
        Console.WriteLine("Insira um numero para calcular o factorial: ");


        int num2 = Convert.ToInt32(Console.ReadLine());

        bool prime = IsPrime(num2);

      Console.WriteLine(prime);
  
    }

  
     




    public static long CalcularFactorial(int n) {
        
        // Calculating factorial of number
        long factorial = 1;

        for (int i = 2; i <= n; i++) {

            factorial = factorial * i;
        }

        return factorial;
    }

public static bool IsPrime(int num)

{
    if (num <= 1) return false; // Not prime if less than or equal to 1

    if (num == 2) return true; // 2 is prime

   for(int i = 2; i*i <= num; i++) // Start checking from 2

        if (num % i == 0) return false; // Not prime if divisible by any i

    return true;
}
  }


  