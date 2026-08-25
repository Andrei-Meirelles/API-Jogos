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
       return await _mycontext.Games.ToListAsync();

    }
    public async Task<bool> AnyAsync(string Nome)
        {
            return await _mycontext.Games.AnyAsync(n => n.Nome == Nome);
        }


    public async Task Post(Jogos jogo)
        {
            _mycontext.Games.Add(jogo);
            await _mycontext.SaveChangesAsync();
        }


        public async Task Put()
        {
            await _mycontext.SaveChangesAsync();
        }

        public async Task<Jogos?> GetById(int Id)
        {
            return await _mycontext.Games.FindAsync(Id);
        }
        public async Task Delete(Jogos jogo)
        {
          

            _mycontext.Games.Remove(jogo);
            await _mycontext.SaveChangesAsync();
        }

}
}