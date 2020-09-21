## Introdução
Projeto onde consulta filmes e gêneros da api [TMDb](https://developers.themoviedb.org/3) e retorna os filmes com sua data de lançamento e seus gêneros. 
 

## Rotas utilizadas na api TMDb
- https://api.themoviedb.org/3/movie/upcoming?api_key=c294f48b4949777fe5217d302ae7a71d&language=pt-BR&page=1
- https://api.themoviedb.org/3/genre/movie/list?api_key=c294f48b4949777fe5217d302ae7a71d&language=pt-BR

## Arquitetura
A api foi construída em 3 camadas:
1. Api
2. Domain
3. Infraestructure

#### Api
Esta parte responsável por receber as requisições

#### Domain
Parte responsável pelos modelos e por conta do projeto ser menor, coloquei junto a camada as manipulações de eventos no diretorio Handlers.

#### Infraestructure
Parte responsável por consultar e mapear os dados

## Padrões, Princípios E Filosofias
No projeto foi utilizado os padrões de Responsabilidade Únidade, Interface e Injeção de Dependência no intuito do baixo acoplamento, na maior facilidade de manutenção e/ou implementação de novas funcionalidades.

Os handlers, que no meu entendimento não seja um padrão mas uma boa prática, foi utilizado com a intenção de facilitar o local onde se manipula os eventos, porém para uma melhor separação poderia criar mais uma camada chamada Service para melhor organização caso haja muitos handlers, mas como dito anteriormente por ser somente uma unica handler foi colocado na propria camada Domain.

Finalizando, para complementar em todos os projetos sempre tento buscar a filosofia "Clean Code", onde busco soluções simples com foco para que companheiros de equipe consigam visualizar o código e interpretar com mais facilidade sua intenção, realizar manutenções e aumentar a produtividade. 

## Ferramentas de Desenvolvimento
- Visual Studio Community 2019
- [Json2CSharp](https://json2csharp.com/)
- Json Viewer
