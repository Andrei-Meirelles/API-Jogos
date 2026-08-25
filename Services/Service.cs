using Microsoft.EntityFrameworkCore;

namespace projeto1
{
    
    public class JogosService
    {
        private readonly JogoRepository _repository;

        public JogosService(JogoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DtoResponse>?> Get()
        {
            var jogos = await _repository.Get();
            if (jogos.Count <= 0)
            {
                return null;
            }
           var jogossemid = jogos.Select(j => new DtoResponse
           {
            Nome = j.Nome,
            Avaliacao = j.Avaliacao,
            Status = j.Status




           }).ToList();
            {
                
            };

            return jogossemid;

            
        }
    }
}