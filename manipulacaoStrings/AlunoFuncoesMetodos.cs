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

        
        Console.WriteLine("Enter a Number : ");

        int number = Convert.ToInt32(Console.ReadLine());

            long factorial =  1;

            /*do
            {
                factorial = factorial * number;
                number--;
            } while (number > 0);

            Console.Write($"The Factorial is: {factorial}");

            Console.ReadLine();*/

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
        } 
        
            Console.Write($"The Factorial is: {factorial}");     
    }}
