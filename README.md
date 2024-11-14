# Projeto Calculadora API - React
 
Este projeto é uma API de calculadora desenvolvida em ASP.NET Core com um frontend em React. Ele permite realizar operações matemáticas básicas (adição, subtração, multiplicação e divisão) por meio de chamadas autenticadas à API.

## Funcionalidades

- **Autenticação**: A API usa autenticação JWT para proteger as operações.
- **Operações Matemáticas**: Permite realizar cálculos básicos (adição, subtração, multiplicação, divisão).
- **Frontend em React**: Interface web onde os usuários podem fazer login e realizar cálculos interagindo com a API.

## Tecnologias Utilizadas

- **ASP.NET Core** (para o backend)
- **React** (para o frontend)
- **JWT** (para autenticação)
- **Axios** (para as requisições HTTP no frontend)

## Pré-requisitos

- **.NET SDK** (para o backend): [Instalar aqui](https://dotnet.microsoft.com/download)
- **Node.js e npm** (para o frontend): [Instalar aqui](https://nodejs.org)

## Como Executar o Projeto

### Passo 1: Clone o Repositório

```bash
git clone https://github.com/LeoJanuario/ProjetoCalculadora.git
cd ProjetoCalculadora
```

### Passo 2: Configuração do Backend (API)

1. Navegue até a pasta do projeto de API:
    ```bash
    cd CalculadoraAPi
    ```

2. Instale as dependências e compile o projeto:
    ```bash
    dotnet restore
    dotnet build
    ```

3. Inicie o servidor:
    ```bash
    dotnet run
    ```

4. A API estará disponível em `https://localhost:7142`.

### Passo 3: Configuração do Frontend (React)

1. Abra um novo terminal e navegue até a pasta do frontend:
    ```bash
    cd calculadora-frontend
    ```

2. Instale as dependências do frontend:
    ```bash
    npm install
    ```

3. Inicie o servidor de desenvolvimento do React:
    ```bash
    npm start
    ```

4. O frontend estará disponível em `http://localhost:3000`.

## Usando a Aplicação

### Login

1. Acesse `http://localhost:3000`.
2. Insira o nome de usuário e senha para autenticar-se.
3. Após o login, o token JWT será armazenado e usado nas requisições para a API.

### Realizando Cálculos

1. Após o login, preencha os campos "Valor 1", "Valor 2" e selecione a operação desejada (adição, subtração, multiplicação ou divisão).
2. Clique no botão **Calcular**.
3. O resultado será exibido na tela.
