# API REST para converter quilômetros e Anos-luz.
_Projeto para processo seletivo Netcon Americas._

Nesta API temos um conversor de Quilômetros para Anos-luz e Anos-luz para Quilômetros. 

## Como executar:

Para executar basta baixar o repositório e executar-lo pelo Visual Studio. 

## Como usar:

Após executar, o Visual Studio irá criar a conexão local e abrir a interface Swagger com os detalhes da API. 
Com uma interface mais amigável, a API pode ser testada pelo próprio Swagger.

Para um uso mais simples, basta acessar a URL `https://localhost:7022/api/Converter?[Parâmetro]`
Substituindo [Parâmetro] por:
- `km=[valor]`: Para converter de Quilômetros para Anos-luz. Exemplo: `https://localhost:7022/api/Converter?km=2`
- `anosLuz=[valor]` Para converter de Anos-luz para Quilômetros. Exemplo: `https://localhost:7022/api/Converter?anosLuz=2`

## Detalhes do funcionamento do código:

Nesse projeto foi utilizado o modelo de Web Api do Visual Studio, que cria um controlador MVC e a interface Swagger.

Dentro do controlador existe uma função Get responsável pelo tratamento dos parâmetros, onde é checado se o valor é maior ou igual a 1. Caso positivo, é feito o calculo, instacia o modelo de resposta e retorna. Caso negativo, instancia o modelo de resposta com as informações do erro.
