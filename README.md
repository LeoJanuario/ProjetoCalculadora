# Calculadora - API e Frontend em React

## Descrição do Projeto

Este projeto é uma calculadora funcional que combina uma API desenvolvida em **C#** e um **frontend em React**. Ele permite realizar operações matemáticas básicas, integrando o backend com o frontend por meio de chamadas HTTP. Além disso, o sistema utiliza autenticação JWT para controlar o acesso.

---

## Funcionalidades

### API (C#)

- Endpoints para operações matemáticas básicas (adição, subtração, multiplicação e divisão).
- Autenticação e autorização via JWT.
- Tratamento de erros para operações inválidas (ex: divisão por zero).

### Frontend (React)

- Interface de usuário para realizar cálculos.
- Formulário de login com autenticação via JWT.
- Consumo dos serviços da API.

---

## Tecnologias Utilizadas

- **Backend:** C# com .NET Core
- **Frontend:** React
- **Autenticação:** JWT
- **Containerização:** Docker e Docker-Compose

---

## Como Executar o Projeto

### Passo 1: Clone o Repositório

```bash
git clone https://github.com/seu-usuario/calculadora-api-react.git
cd calculadora-api-react
```

### Passo 2: Instale as Dependências

#### Backend

```bash
cd api
dotnet restore
```

#### Frontend

```bash
cd ../frontend
npm install
```

### Passo 3: Inicie o Backend

```bash
cd ../api
dotnet run
```

### Passo 4: Inicie o Frontend

```bash
cd ../frontend
npm start
```

### Passo 5: Acesse o Sistema

- Frontend: [http://localhost:3000](http://localhost:3000)
- API: [http://localhost:5000](http://localhost:5000)
