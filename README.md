# Trabalho Prático 2 - Desenvolvimento de Razor Pages

Este projeto contém as implementações dos 12 exercícios propostos utilizando Razor Pages com ASP.NET Core.

---

## Enunciado

1. **Criando uma Razor Page com PageModel e Propriedade Vinculada**

   Imagine uma aplicação interna para cadastro de cidades turísticas. Crie uma Razor Page chamada `CreateCity.cshtml` com um `PageModel` que contenha uma propriedade pública `CityName`, vinculada por model binding com `[BindProperty]`.

   **Tarefas:**
   - Crie o arquivo Razor Page em uma pasta `Pages/CityManager`.
   - Implemente um formulário que envie o nome da cidade via método POST.
   - Exiba o nome submetido no navegador após o envio.

2. **Trabalhando com Model Binding e Handler Parameters**

   Altere o exercício anterior para utilizar parâmetros no handler `OnPost` ao invés de usar propriedades com `BindProperty`. Isso permitirá comparar as abordagens e entender quando usar cada uma.

   **Tarefas:**
   - Remova a propriedade pública vinculada.
   - Adicione um parâmetro `string cityName` no método `OnPost`.
   - Exiba a mensagem com o nome da cidade recebida via handler.

3. **Validação do Lado do Servidor com Data Annotations**

   Valide os dados de entrada para garantir que o nome da cidade tenha no mínimo 3 caracteres.

   **Tarefas:**
   - Crie uma classe `InputModel` aninhada ao `PageModel`.
   - Adicione a propriedade `CityName` com o atributo `[Required]` e `[MinLength(3)]`.
   - Implemente a lógica de `ModelState.IsValid` no `OnPost`.
   - Mostre as mensagens de erro quando a validação falhar.

4. **Validação do Lado do Cliente com Tag Helpers**

   Melhore a experiência do usuário exibindo mensagens de validação antes mesmo de enviar o formulário.

   **Tarefas:**
   - Utilize os tag helpers `asp-for` e `asp-validation-for` no formulário.
   - Referencie o `ValidationScriptsPartial` na seção scripts da página.
   - Valide client-side e verifique se o comportamento se alinha às regras do servidor.

5. **Encapsulando Entrada em Objeto Complexo**

   Refatore a lógica de entrada para trabalhar com um objeto complexo: um país. Crie uma Razor Page `CreateCountry.cshtml`.

   **Tarefas:**
   - Crie a classe `Country` com propriedades `CountryName` e `CountryCode`.
   - Use um `InputModel` com as mesmas propriedades e vincule-o ao `PageModel` com `[BindProperty]`.
   - Submeta os dados e crie uma instância de `Country` a partir do `InputModel`.

6. **Validação de Código ISO do País (2 letras)**

   Adicione validação para garantir que o código do país (ex: "BR") tenha exatamente 2 caracteres.

   **Tarefas:**
   - Utilize `[StringLength(2, MinimumLength = 2)]` no `InputModel`.
   - Apresente mensagens de erro usando tag helpers.
   - Teste o comportamento com dados inválidos ("B", "BRA", "").

7. **Trabalhando com Vários Registros Simultaneamente**

   Implemente um formulário para cadastrar múltiplos países em uma única submissão.

   **Tarefas:**
   - Crie uma lista `List<InputModel>` no `PageModel` com `[BindProperty]`.
   - Gere dinamicamente 5 linhas no formulário (use `for` loop) para preenchimento.
   - Exiba os países submetidos após a submissão.

8. **Roteamento com Parâmetros na URL**

   Implemente uma página `CityDetails.cshtml` que recebe o nome da cidade via URL.

   **Tarefas:**
   - Configure a diretiva `@page "{cityName}"`.
   - Utilize `RouteData.Values` ou um parâmetro `OnGet(string cityName)`.
   - Exiba uma mensagem como "Você está vendo detalhes de: Rio de Janeiro".

9. **Criando URLs com Tag Helpers**

   Adicione links para cada cidade de uma lista usando tag helpers de roteamento.

   **Tarefas:**
   - Crie uma lista `List<string> Cities = ["Rio", "São Paulo", "Brasília"]`.
   - Use `asp-page` e `asp-route-cityName` para montar os links dinâmicos.
   - Verifique se os links direcionam corretamente para `CityDetails`.

10. **Manipulação de Arquivos: Escrita**

    Crie uma página `SaveNote.cshtml` que permita ao usuário escrever um texto e salvá-lo em arquivo `.txt` no `wwwroot/files`.

    **Tarefas:**
    - Use um `InputModel` com uma propriedade `Content`.
    - Ao submeter, crie um arquivo com nome `note-{timestamp}.txt`.
    - Confirme a escrita e exiba link para download.

11. **Manipulação de Arquivos: Leitura**

    Adicione uma funcionalidade que leia os arquivos `.txt` do diretório `wwwroot/files` e exiba seus conteúdos.

    **Tarefas:**
    - Liste todos os arquivos da pasta `files`.
    - Mostre links para visualização.
    - Abra e exiba o conteúdo do arquivo selecionado.

12. **Validação Customizada com ModelState**

    Implemente uma regra onde o nome do país e o código devem começar com a mesma letra.

    **Tarefas:**
    - No `OnPost`, verifique se o primeiro caractere de `CountryName` é igual ao de `CountryCode`.
    - Caso contrário, adicione erro via `ModelState.AddModelError`.
    - Exiba mensagem de erro próxima ao campo correspondente.

---

