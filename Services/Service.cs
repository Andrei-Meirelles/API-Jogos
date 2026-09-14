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

        public async Task<List<Jogos>> Get2(

            int page = 1,
            int pagesize = 10)

        { 
            int skip = (page - 1) * pagesize;

            return await _repository.Get1(skip, pagesize);







        }

        public async Task<(Jogos? jogos, string? erro)> Post(DtoRequest jogodto)
        {
            if (jogodto == null)
            {
                return (null, "Informações inválidas");
            }

            var nomeIgual = await _repository.AnyAsync(jogodto.Nome);
            if(nomeIgual)
            {

               
                return (null, "Jogo ja existente");
              

            }

            var jogonovo = new Jogos(jogodto.Nome, jogodto.Avaliacao, jogodto.Status);

            await _repository.Post(jogonovo);

            return (jogonovo, null);

        }
        public async Task<Jogos?> Put(DtoRequest jogodto, int Id)
        {
           var jogolegal = await _repository.GetById1(Id);
           if (jogolegal == null)
            {
                return null;
            }

            jogolegal.Nome = jogodto.Nome;
            jogolegal.Avaliacao = jogodto.Avaliacao;
            jogolegal.Status = jogodto.Status;

            await _repository.Put();
            return jogolegal;
        }

        public async Task<bool> Delete(int Id)
        {
            var jogoDeletar = await _repository.GetById1(Id);
            if(jogoDeletar == null)
            {
                return false;
            }

            await _repository.Delete(jogoDeletar);

            return true;
        }

        public async Task<Jogos?> GetById2(int Id)
        {
            return await _repository.GetById1(Id);

            
        }

        
        public async Task<Jogos?> GetByName(string Name)
        {
            return await _repository.GetByName(Name);
        }

    }
}