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

        
        Console.WriteLine("Insira um numero para calcular o factorial: ");

        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(num);

        Console.Write($"O Factorial de : {num} =  {factorial}\n");   

            

/////////////////////////////////////////////////////////////////
    
       Console.WriteLine("EXERCÍCIO 2: Números primos\n");
      
       Console.WriteLine("===============================================");

        Console.WriteLine("Insira um numero para verificar se e primo:\n ");

        int numb = Convert.ToInt32(Console.ReadLine());

        bool primo = VerificarPrimo(numb);

        Console.WriteLine($"Numero: {numb} = {primo}");
  
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
  }


  