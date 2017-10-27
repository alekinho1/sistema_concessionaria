using System;

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

 

   

    static void VenderCarro(){
    }

    static void ListarCarro(){

    }
    }
}
