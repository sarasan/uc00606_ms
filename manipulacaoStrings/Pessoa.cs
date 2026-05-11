using ExerciciosAula02;

public class Pessoa
  {
     //Atributos públicos para facilitar o acesso
    public string Nome{get;set;}
    public int Idade{get;set;}

    //Construtor para facilitar a criação de objetos
    // O construtor é um método especial que é chamado quando criamos um novo objeto da classe. Ele é usado para inicializar os atributos do objeto.
    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }

    // "override "é forma de "Sobrescreve" qualquer  método, neste exemplo o ToString(). Usamos para exibir os dados de forma legível
    // isto faz parte do polimorfismo, onde cada classe pode ter sua própria implementação de um método
    // maiores detalhes na  UC00608 P.O.O .Assim, quando chamamos Console.WriteLine(pessoa), ele exibe o nome e idade formatados
    public override string ToString()
    {
      return $"{Nome} ({Idade} anos)";
    }


      public override bool  Equals(object? obj)
    {
        if(obj == null)
        {
            return false;
        }

        if (obj is not Pessoa outraPessoa)
    {
      return false;
    }
    return  Nome == outraPessoa.Nome && Idade == outraPessoa.Idade;
    }

   public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Idade);
    }


    public void Apresentar() => Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}");
 
  }