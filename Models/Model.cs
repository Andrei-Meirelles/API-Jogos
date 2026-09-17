using Swashbuckle.AspNetCore.Annotations;

namespace projeto1

{
    public class Jogos
    {
        public int Id {get; set;}

        public string Nome {get; set;} = string.Empty;
         public decimal Avaliacao {get; set;}
        public StatusJogo Status {get; set;}

        public Jogos(string nome, decimal avaliacao, StatusJogo status)
        {
            Nome = nome;
            Avaliacao = avaliacao;
            Status = status;
        }

    }
}