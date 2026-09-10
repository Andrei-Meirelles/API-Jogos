# GameLibraryAPI 

REST API desenvolvida em C# com ASP.NET Core para gerenciamento de uma biblioteca de jogos.

O projeto permite cadastrar, consultar, atualizar e remover jogos, utilizando SQL Server para persistência dos dados.

##  Tecnologias

- C#
- .NET / ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- REST API

##  Funcionalidades

- [x] Cadastrar jogos
- [x] Listar jogos
- [x] Buscar jogo por ID
- [x] Atualizar jogos
- [x] Remover jogos
- [x] Validação dos dados
- [x] Persistência com SQL Server
- [x] Paginação
- [x] Enum para status do jogo
- [x] Documentação dos endpoints com Swagger

##  Dados do jogo

Cada jogo possui informações como:

- Nome
- Avaliação
- Status

Os possíveis status são:

- `Jogando`
- `Zerado`
- `Abandonado`

##  Estrutura

O projeto utiliza uma separação de responsabilidades entre:

- **Controllers** → recebem as requisições HTTP e retornam as respostas.
- **Services** → concentram as regras de negócio.
- **Repositories** → responsáveis pelo acesso ao banco de dados.
- **DTOs** → controlam os dados recebidos e enviados pela API.
- **Models** → representam as entidades utilizadas pela aplicação.

##  Banco de dados

O projeto utiliza **SQL Server** com **Entity Framework Core** para acesso e persistência dos dados.

##  Documentação

A API possui documentação interativa através do Swagger.

Com a aplicação em execução, acesse:

```text
/swagger
