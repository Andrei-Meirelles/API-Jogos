using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Swashbuckle.AspNetCore.Annotations;
namespace projeto1
{
    public class DtoRequest


           

           
    {
        
      
         public string Nome {get; set;} = string.Empty;

        
        [Range(0,10)]
        public int Avaliacao {get; set;}

      
         public StatusJogo Status {get; set;} 

    }
}