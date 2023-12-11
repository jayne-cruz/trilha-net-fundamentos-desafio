# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
A implementação do sistema de estacionamento foi realizada seguindo os requisitos especificados. Abaixo está um resumo das soluções implementadas para cada método da classe `Estacionamento`:

### AdicionarVeiculo

*   **Descrição**: Este método é responsável por adicionar um novo veículo ao estacionamento. Ele solicita ao usuário para digitar a placa do veículo e armazena essa informação na lista `veiculos`.
*   **Implementação**: Utilizei `Console.ReadLine()` para capturar a entrada do usuário e `veiculos.Add(placa)` para adicionar a placa à lista de veículos.

### RemoverVeiculo

*   **Descrição**: Este método remove um veículo do estacionamento. Primeiro, verifica se a placa digitada pelo usuário corresponde a um veículo estacionado. Se o veículo estiver presente, pede ao usuário para informar a quantidade de horas que o veículo permaneceu estacionado e calcula o valor total a ser cobrado.
*   **Implementação**: Utilizei `veiculos.Any(x => x.ToUpper() == placa.ToUpper())` para verificar a existência do veículo e `veiculos.Remove(placa)` para removê-lo da lista após o cálculo do valor total.

### ListarVeiculos

*   **Descrição**: Este método lista todos os veículos atualmente estacionados. Se não houver veículos, exibe uma mensagem indicando que o estacionamento está vazio.
*   **Implementação**: Implementei um loop `foreach` para percorrer a lista `veiculos` e exibir cada placa, usando `Console.WriteLine()` para mostrar as informações no console.

### Menu Interativo

*   **Descrição**: O programa oferece um menu interativo que permite ao usuário escolher entre cadastrar, remover ou listar veículos, além de encerrar o programa.
*   **Implementação**: Usei um loop `while` junto com uma estrutura `switch` para processar a entrada do usuário e chamar os métodos correspondentes da classe `Estacionamento`.

Ao final, essas implementações garantem que o sistema de estacionamento funcione de acordo com os requisitos do desafio, permitindo gerenciar eficientemente os veículos estacionados.

