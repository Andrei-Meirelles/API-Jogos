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

    public async Task<List<Jogos>> Get1(int page, int pagesize)
    {
            return await _mycontext.Jogos.Skip(page).Take(pagesize).ToListAsync();

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
            return await _mycontext.Jogos.FirstOrDefaultAsync(n => n.Nome == Name);
        }


}
}