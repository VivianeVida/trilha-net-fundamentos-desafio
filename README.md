# DIO - Trilha .NET - Fundamentos

www.dio.me

Desafio de projeto
que usa os conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

Proposta
Construir uma classe chamada "Estacionamento", conforme o diagrama abaixo: Diagrama de classe estacionamento

A classe contém três variáveis, sendo:

precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

veículos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

AdicionarVeículo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veículos.

RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.

ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

Cadastrar veículo
Remover veículo |
Listar veículos
Encerrar
Solução
Usando o código disponibilizado, dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
