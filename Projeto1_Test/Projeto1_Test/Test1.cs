using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using projeto1;



namespace Projeto1_Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public async Task DeveriaRetornarTrue()
        {
            var options = new DbContextOptionsBuilder<DbGames>()
                .UseInMemoryDatabase(databaseName: "Teste")
                .Options;
            var mycontext = new DbGames(options);
            var jogo = new Jogos("121", 1);

            var repository = new JogoRepository(mycontext);

         mycontext.Jogos.Add(jogo);
           await mycontext.SaveChangesAsync();

            var res = await repository.AnyAsync(jogo.Nome);
           
            
                 Assert.IsTrue(res);

            var resultado = await repository.AnyAsync("Minecraft");

            Assert.IsFalse(resultado);
        }
    }
}
