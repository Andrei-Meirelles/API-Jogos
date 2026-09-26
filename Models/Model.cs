using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace projeto1

{
    public class Jogos
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
            

        [Column(TypeName = "decimal(4,2)")]
         public decimal Avaliacao { get; set; }
        public StatusJogo Status { get; set; }

        public Jogos(string nome, decimal avaliacao, StatusJogo status)
        {
            Nome = nome;
            Avaliacao = avaliacao;
            Status = status;
        }

    }
}