using ExerciciosAula02;

public class Pessoa
  {
     //Atributos públicos para facilitar o acesso
    public string Nome;
    public int Idade;

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
  }