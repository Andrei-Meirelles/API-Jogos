using Swashbuckle.AspNetCore.Annotations;
namespace projeto1
{
    public class DtoResponse
    {
        public string Nome {get; set;} = string.Empty;
               public decimal Avaliacao {get; set;}
                public StatusJogo Status {get; set;} 

        

    }
}