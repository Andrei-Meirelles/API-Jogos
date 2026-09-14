using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Swashbuckle.AspNetCore.Annotations;
namespace projeto1
{
    public class DtoRequest


           

           
    {

        [Required]
        [StringLength(60)]
        [SwaggerSchema(Description = "Nome do jogo")]
        [DefaultValue("Minecraft")]
         public string Nome {get; set;} = string.Empty;

        [Required]
        [DefaultValue(10)]
        [SwaggerSchema(Description = "Avaliação do jogo")]
        [Range(0,10)]
        public int Avaliacao {get; set;}


        [Required]
        [SwaggerSchema(Description = "Status do jogo")]
         public StatusJogo Status {get; set;} 

    }
}