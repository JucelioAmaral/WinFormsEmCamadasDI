
# Relacionamento Dono e Cão
# >>Windows Forms em camadas usando Injeção de Dependência<<

Aplicativo Windows Form C# feito em .Net Framework 4.6.1, em camadas, usando Entity framework para persistencia, acesso, consultas e relatórios ao banco de dados SQLServer, como SGBD.

## Pré requisitos
 
1. [Framework 4.6.1](https://www.microsoft.com/pt-br/download/details.aspx?id=49982)
2. [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)

## Como baixar o código

git clone https://github.com/JucelioAmaral/WinFormsEmCamadasDI.git

## Como configurar?

1. Abrir a solution;
2. Configurar o arquivo "App.config" com a connectionString, apontando para o banco SQL server;
3. Abrir o Console do Visual Studio;
4. Instale o pacote pelo Nuget ou Package Manager Console: Install-Package Ninject;
5. Executar o comando: Add-Migration MigracaoInicial;
6. Executar o comando: Update-Database;
7. Executar o App pelo Visual Studio.

## Como executar o app?

1. Abrir a solution;
2. Clicar no botão em Start.