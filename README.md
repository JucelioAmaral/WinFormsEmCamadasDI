
# Relacionamento Dono e Cão
# >>Windows Forms em camadas usando Injeção de Dependência<<

Aplicativo Windows Form C# feito em .Net Framework 4.6.1, em camadas, usando Entity framework para persistencia, acesso, consultas e relatórios ao banco de dados SQLServer, como SGBD.

## Pré requisitos
 
1. [Framework 4.6.1](https://www.microsoft.com/pt-br/download/details.aspx?id=49982)
2. [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)

## Como baixar o código

git clone https://github.com/JucelioAmaral/WinFormsEmCamadasDI.git

## Como configurar?

1. Executar o ScriptWinForDI.sql;
2. Abrir a solution;
3. Configurar o arquivo "App.config" com a connectionString, apontando para o banco SQL server;
4. Abrir o Console do Visual Studio;
5. Instale o pacote pelo Nuget ou Package Manager Console: Install-Package Ninject;
6. Executar o App pelo Visual Studio.

## Como executar o app?

1. Abrir a solution;
2. Clicar no botão em Start.


## Observações:
1. Obs1: You cannot add a reference to a .NET Core project to a .NET Framework project.
If you want to share code between .NET Core and .NET Framework apps / libraries, the shared project must target .NET Standard. If you create a .NET Standard 2.0 project, it could be used in .NET Framework 4.6.1+ projects and .NET Core 2.0+ projects.
https://forums.asp.net/t/2144362.aspx?Error+it+cannot+be+referenced+by+a+project+that+targets+NETFramework+version+v4+7+2+

1. Obs2: Solução para injetar a dependencia nos forms:
https://pt.stackoverflow.com/questions/184157/d%C3%BAvida-sobre-como-implementar-uma-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-no-c-utilizando-o-ninj

3. Obs3: Solução para injeção de dependencia do AutoMapper funcionar:
https://stackoverflow.com/questions/43560555/how-do-i-use-ninject-to-inject-automapper-mapper-in-place-of-imapper
