# ValeAtivos325219722

Projeto ASP.NET Core Web API em C# com MVC, Entity Framework Core, SQLite e Swagger.

## Como executar

```bash
cd ValeAtivos325219722
dotnet restore
dotnet run
```

Acesse o Swagger:

```text
http://localhost:5050/swagger
```

## Rotas

### POST /api/equipamentos

Exemplo de JSON:

```json
{
  "nome": "Escavadeira CAT-7495",
  "tipo": "Mina",
  "localizacao": "Carajás",
  "capacidadeProcessamento": 12000,
  "dataUltimaManutencao": "2026-05-04T00:00:00",
  "emOperacao": true
}
```

### GET /api/equipamentos
Lista todos os ativos cadastrados.

### GET /api/equipamentos/{id}
Busca um ativo específico pelo ID.

## Limpeza antes do GitHub

```bash
dotnet clean
```

Depois, apague as pastas `bin` e `obj`, caso existam.
