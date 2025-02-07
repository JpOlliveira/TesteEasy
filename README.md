Aqui está o `README.md` detalhado para o seu código, explicando o problema, os diferentes métodos utilizados e as melhorias aplicadas para destacar suas habilidades. 🚀

---

## 📌 Detect Capital Use - C# Implementation

Este projeto implementa uma solução para o problema **"Detect Capital Use"**, onde verificamos se o uso de maiúsculas em uma palavra está correto conforme três regras:

1. **Todas as letras são maiúsculas** → `"USA"` ✅
2. **Todas as letras são minúsculas** → `"leetcode"` ✅
3. **Apenas a primeira letra é maiúscula** → `"Google"` ✅

Caso contrário, a palavra é inválida. Por exemplo: `"FlaG"` ❌

---

## 📝 Exemplo

### Entrada:
```csharp
string word = "USA";
```
### Saída:
```csharp
true
```

### Entrada:
```csharp
string word = "FlaG";
```
### Saída:
```csharp
false
```

---

## ⚙️ Implementação

A solução foi desenvolvida utilizando **Clean Code** e princípios do **SOLID**, garantindo modularidade e boas práticas de desenvolvimento. 

### 📌 Métodos Utilizados

Foram implementadas **três abordagens diferentes** para resolver o problema:

1. **Comparação Direta** (`DetectCapitalUse`) → Utiliza verificações diretas com `ToUpper()` e `ToLower()`.
2. **Expressão Regular (Regex)** (`DetectCapitalUseWithRegex`) → Utiliza um padrão regex para validar a string.
3. **Switch Expression** (`DetectCapitalUseWithSwitch`) → Implementa a verificação com `switch` para melhor legibilidade.

---

## 📂 Estrutura do Código

```
📂 DetectCapitalUse
 ├── 📄 Solution.cs   # Classe com as três abordagens diferentes
 ├── 📄 InputValidator.cs  # Classe para validar constraints do input
 ├── 📄 Program.cs    # Ponto de entrada e execução dos testes
 ├── 📄 README.md     # Documentação do projeto
```

---

## 🔍 Explicação dos Métodos

### 1️⃣ **Método Tradicional (Comparação Direta)**
```csharp
public bool DetectCapitalUse(string word)
{
    bool result = ValidateAllUpperCase(word) ||
                  ValidateAllLowerCase(word) ||
                  ValidateFirstUpperCase(word);

    return result;
}

private bool ValidateAllUpperCase(string word) => word.ToUpper() == word;
private bool ValidateAllLowerCase(string word) => word.ToLower() == word;
private bool ValidateFirstUpperCase(string word) => char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1);
```
📌 **Explicação**: Verifica se a palavra está inteiramente em maiúsculas, minúsculas ou se apenas a primeira letra é maiúscula.

---

### 2️⃣ **Método com Regex**
```csharp
public bool DetectCapitalUseWithRegex(string word)
{
    return Regex.IsMatch(word, @"^([A-Z]+|[a-z]+|[A-Z][a-z]+)$");
}
```
📌 **Explicação**: A expressão regular verifica se a palavra se encaixa em um dos três padrões válidos.

---

### 3️⃣ **Método com Switch Expression**
```csharp
public bool DetectCapitalUseWithSwitch(string word)
{
    return word switch
    {
        _ when ValidateAllUpperCase(word) => true,
        _ when ValidateAllLowerCase(word) => true,
        _ when ValidateFirstUpperCase(word) => true,
        _ => false
    };
}
```
📌 **Explicação**: Utiliza `switch` para organizar melhor as condições e aumentar a legibilidade do código.

---

## ✅ Constraints Implementadas

- **Comprimento da palavra entre 1 e 100 caracteres** (`1 <= word.length <= 100`).
- **Apenas letras maiúsculas e minúsculas** (`word consists of lowercase and uppercase English letters`).
- **Validação encapsulada na classe `InputValidator`** para garantir que apenas entradas válidas sejam processadas.

```csharp
public static class InputValidator
{
    public static bool IsValid(string word)
    {
        return !string.IsNullOrEmpty(word) &&
               word.Length >= 1 && word.Length <= 100 &&
               Regex.IsMatch(word, @"^[a-zA-Z]+$");
    }
}
```

---

## 📌 Saída do Programa

Ao executar o código, o `Program.cs` imprime os resultados de cada abordagem:

```csharp
Function: DetectCapitalUse, Input: "USA", Output: True
Function: DetectCapitalUse, Input: "FlaG", Output: False
Function: DetectCapitalUse, Input: "Google", Output: True
Function: DetectCapitalUse, Input: "leetcode", Output: True
Function: DetectCapitalUseWithRegex, Input: "USA", Output: True
Function: DetectCapitalUseWithSwitch, Input: "FlaG", Output: False
```

---

## 🚀 Como Rodar o Código

### 1️⃣ Clonar o repositório
```sh
git clone https://github.com/seuusuario/DetectCapitalUse.git
cd DetectCapitalUse
```

### 2️⃣ Compilar e rodar
```sh
dotnet build
dotnet run
```

---

## 🏆 Conclusão

Esse projeto mostra diferentes maneiras de validar o uso correto de maiúsculas em palavras, aplicando princípios de código limpo e demonstrando versatilidade na resolução de problemas. 🔥💡

---
