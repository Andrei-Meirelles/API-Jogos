namespace projeto1
{
    public class Jogos
    {
        public int Id {get; set;}
        public string Nome {get; set;} = string.Empty;
         public int Avaliacao {get; set;}
        public string Status {get; set;} = string.Empty;

        public Jogos(string nome, int avaliacao)
        {
            Nome = nome;
            Avaliacao = avaliacao;
        }

    }
}