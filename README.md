# WebApi Restaurante

## Tecnológias utilidade

* Linq e Lambda
* EF Core - EntityFrameWorkCore
* SQL Server
* AutoMapper
* .Net Core
* Swagger
* JWT - Authentication
* Docker

## Estrutura do Projeto

O projeto foi estruturado em camadas utilizando a arquiterura Union.

- Camada Domain: Models e Repositories.
- Camada Data: Classe de contexto que faz a integração com a base de dados, Mapping e Repositories.
- Camada Application: Interfaces, AutoMapper e ViewModels.
- Camada Infraestrutura: Classe contendo as (Dependency Injection).