using System;
using System.IO;
namespace sistema_concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            do
            {
                System.Console.WriteLine("----Menu Principal---- \n ----Esolha uma opção----");
                System.Console.WriteLine("1 - Cadastrar cliente");
                System.Console.WriteLine("2 – Cadastrar Carro");
                System.Console.WriteLine("3 – Vender Carro");
                System.Console.WriteLine("4 – Listar Carros vendidos no dia");
                System.Console.WriteLine("5 -  Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Cliente cliente1 = new Cliente();
                        cliente1.CadastrarCliente();
                        break;

                    case "2":
                        Carro carro1 = new Carro();
                        carro1.CadastrarCarro();
                        break;

                    case "3":
                        VenderCarro();
                        break;

                    case "4":
                        ListarCarro();
                        break;
                }
            } while (opcao != "5");


        }





        static void VenderCarro()
        {

            System.Console.WriteLine("Carros Disponíveis...");

            string[] carrosCadastados = System.IO.File.ReadAllLines("Cadastro de Carros.csv");

            foreach (string linha in carrosCadastados)
            {
                if (linha.Contains("Disponível") == true)
                {
                    System.Console.WriteLine(linha);
                }
            }


            System.Console.WriteLine("Digite o código do veículo que deseja comprar...");
            string codigo = Console.ReadLine();

            System.Console.WriteLine("O Carro selecionado é: \n");
            foreach (string linha in carrosCadastados)
            {
                if (linha.Contains(codigo) == true)
                {
                    System.Console.WriteLine(linha);
                    string[] split = linha.Split(";");
                    int valor = Convert.ToInt32(split[6]);
                    System.Console.WriteLine("O valor do carro é: R$" + valor);

                    string pagamento;
                    int parcelas;

                    System.Console.WriteLine("Qual a forma de pagamento? \n 1 - A vista \n 2 - A prazo \n 3 - Cancelar");
                    pagamento = Console.ReadLine();

                    switch (pagamento)
                    {
                        case "1":
                            System.Console.WriteLine("Você escolheu pagar a Vista e vai receber um desconto de 5%");
                            System.Console.WriteLine("Valor com desconto R$" + valor * 0.95);





                            System.Console.WriteLine("Confirmar compra? \n 1 - Sim \n 2 - Não");
                            string confirmar = Console.ReadLine();

                            System.Console.WriteLine("Digite o CPF ou CNPJ do cliente ");
                            string documento = Console.ReadLine();

                            string[] clienteCadastados = System.IO.File.ReadAllLines("Cadastro de Cliente.csv");
                            string clienteEscolhido;

                            foreach (string linhaclientes in clienteCadastados)
                            {
                                if (linhaclientes.Contains(documento) == true)
                                {
                                    System.Console.WriteLine(linhaclientes);
                                    string[] splitclientes = linhaclientes.Split(";");
                                    clienteEscolhido = "Nome: " + splitclientes[0] + "Documento: " + splitclientes[1];

                                    switch (confirmar)
                                    {
                                        case "1":
                                            StreamWriter sw = new StreamWriter("Vendas Realizadas.csv", true);
                                            sw.WriteLine(clienteEscolhido + ";" + "Marca " + split[0] + " Modelo " + split[1]);
                                            sw.Close();
                                            System.Console.WriteLine("Vendido!");
                                            break;

                                        case "2":
                                            break;
                                    }

                                }
                                else
                                {
                                    System.Console.WriteLine("Cliente não encontrado");
                                }
                            }


                            break;


                        case "2":

                            System.Console.WriteLine("Você escolheu pagar parcelado \n Digite o número de parcelas");
                            parcelas = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine("O valor de cada parcela é: R$" + valor / parcelas);

                            System.Console.WriteLine("Confirmar compra? \n 1 - Sim \n 2 - Não");
                            string confirmar2 = Console.ReadLine();

                            System.Console.WriteLine("Digite o CPF ou CNPJ do cliente ");
                            string documento2 = Console.ReadLine();

                            string[] clienteCadastados2 = System.IO.File.ReadAllLines("Cadastro de Cliente.csv");
                            string clienteEscolhido2;

                            foreach (string linhaclientes in clienteCadastados2)
                            {
                                if (linhaclientes.Contains(documento2) == true)
                                {
                                    System.Console.WriteLine(linhaclientes);
                                    string[] splitclientes = linhaclientes.Split(";");
                                    clienteEscolhido2 = "Nome: " + splitclientes[0] + "Documento: " + splitclientes[1];

                                    switch (confirmar2)
                                    {
                                        case "1":
                                            StreamWriter sw = new StreamWriter("Vendas Realizadas.csv", true);
                                            sw.WriteLine(clienteEscolhido2 + ";" + "Marca " + split[0] + " Modelo " + split[1] + " ; " + System.DateTime.Now.Day);
                                            sw.Close();
                                            System.Console.WriteLine("Vendido!");
                                            break;

                                        case "2":
                                            break;
                                    }

                                }
                                else
                                {
                                    System.Console.WriteLine("Cliente não encontrado");
                                }
                            }



                            break;

                        case "3":
                            break;

                    }


                }
            }




        }

        static void ListarCarro()
        {

        }
    }
}
