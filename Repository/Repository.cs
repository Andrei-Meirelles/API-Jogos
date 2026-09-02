using System;
using Microsoft.EntityFrameworkCore;
using projeto1;

namespace projeto1
{
public class JogoRepository
{
private readonly DbGames _mycontext;

    
    public JogoRepository(DbGames mycontext)
    {
        _mycontext = mycontext;
    }

    public async Task<List<Jogos>> Get()
    {
       return await _mycontext.Jogos.ToListAsync();

    }
    public async Task<bool> AnyAsync(string Nome)
        {
            return await _mycontext.Jogos.AnyAsync(n => n.Nome == Nome);
        }


    public async Task Post(Jogos jogo)
        {
            _mycontext.Jogos.Add(jogo);
            await _mycontext.SaveChangesAsync();
        }


        public async Task Put()
        {
            await _mycontext.SaveChangesAsync();
        }

        public async Task<Jogos?> GetById1(int Id)
        {
            return await _mycontext.Jogos.FindAsync(Id);
        }
        public async Task Delete(Jogos jogo)
        {
          

            _mycontext.Jogos.Remove(jogo);
            await _mycontext.SaveChangesAsync();
        }

        
        public async Task<Jogos?> GetByName(string Name)
        {
            return await _mycontext.Jogos.FindAsync(Name);
        }


}
}