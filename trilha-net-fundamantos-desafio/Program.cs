using System;
using System.Collections.Generic;

namespace DesafioFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo ao sistema de estacionamento");

            // Solicitar ao usuário o preço inicial.
            Console.Write("Digite o preço inicial: ");
            decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

            // Solicitar ao usuário o preço por hora.
            Console.Write("Agora, digite o preço por hora (preço de cada hora de permanência): ");
            decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

            // Inicializar o objeto Estacionamento com os preços informados.
            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            int opcao;

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite a placa do veículo: ");
                            string placa = Console.ReadLine();

                            // Chamar o método CadastrarVeiculo do objeto estacionamento.
                            estacionamento.CadastrarVeiculo(placa);
                            Console.WriteLine("Veículo cadastrado com sucesso.");
                            break;

                        case 2:
                            Console.Write("Digite a placa do veículo para remover: ");
                            string placaRemover = Console.ReadLine();

                            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                            int horasPermanencia = Convert.ToInt32(Console.ReadLine());

                            // Chamar o método RemoverVeiculo do objeto estacionamento.
                            decimal precoTotal = estacionamento.RemoverVeiculo(placaRemover, horasPermanencia);

                            Console.WriteLine("Veículo removido. Preço total a pagar: " + precoTotal);
                            break;

                        case 3:
                            Console.WriteLine("Os veículos estacionados são:");

                            // Chamar o método ListarVeiculos do objeto estacionamento.
                            List<string> veiculos = estacionamento.ListarVeiculos();
                            foreach (var veiculo in veiculos)
                            {
                                Console.WriteLine(veiculo);
                            }
                            break;

                        case 4:
                            Console.WriteLine("Encerrando o programa.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            } while (opcao != 4);

            Console.WriteLine("Pressione qualquer tecla para continuar.");
        }
    }

    class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para cadastrar um veículo.
        public void CadastrarVeiculo(string placa)
        {
            veiculos.Add(placa);
        }

        // Método para remover um veículo e calcular o preço total.
        public decimal RemoverVeiculo(string placa, int horasPermanencia)
        {
            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                return precoInicial + (precoPorHora * horasPermanencia);
            }
            return 0;
        }

        // Método para listar os veículos estacionados.
        public List<string> ListarVeiculos()
        {
            return veiculos;
        }
    }
}
