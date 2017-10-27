using System;
using System.IO;

namespace sistema_concessionaria
{
    public class Cliente
    {

        private string nome { get; set; }
        private string cpf { get; set; }
        private string cnpj { get; set; }
        



        public void CadastrarCliente()
        {

            System.Console.WriteLine("Por favor escolha uma opção:");
            System.Console.WriteLine("1 - Cliente Pessoa Física ");
            System.Console.WriteLine("2 Cliente Pessoa Jurídica");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string novo = "1";
                   
                    do
                    {
                        System.Console.WriteLine("Digite o CPF: ");
                        this.cpf = Console.ReadLine();

                        System.Console.WriteLine("Digite o nome: ");
                        this.nome = Console.ReadLine();

                       // System.Console.WriteLine("Digite o endereco ");
                        //this.endereco = Console.ReadLine();

                        string dado = DadosEndereco();

                        System.Console.WriteLine("Deseja Cadastrar novo Cliente Pessoa Física? \n 1 - Sim \n 2 - Não ");
                        novo = Console.ReadLine();

                        StreamWriter sw = new StreamWriter("Cadastro de ClienteCPF.csv", true);
                        sw.WriteLine(nome + ";" + cpf + ";" + dado);
                        sw.Close();

                    } while (novo == "1");
                    break;


                case "2":
                    string novoPJ = "1";

                    do
                    {
                        System.Console.WriteLine("Digite o CNPJ: ");
                        this.cnpj = Console.ReadLine();

                        System.Console.WriteLine("Digite o nome: ");
                        this.nome = Console.ReadLine();

                        string dado = DadosEndereco();

                        System.Console.WriteLine("Deseja Cadastrar novo Cliente Pessoa Jurídica? \n 1 - Sim \n 2 - Não ");
                        novoPJ = Console.ReadLine();

                        StreamWriter swpj = new StreamWriter("Cadastro de ClienteCNPJ.csv", true);
                        swpj.WriteLine(nome + ";" + cnpj + ";" + dado);
                        swpj.Close();

                    } while (novoPJ == "1");
                    break;
            }



        }
        
            public string DadosEndereco(){
                string dadoEndereco;

                System.Console.WriteLine("Qual o logradouro? ");
                string logradouro = Console.ReadLine();
                System.Console.WriteLine("Qual o número: ");
                string numero = Console.ReadLine();
                System.Console.WriteLine("Qual CEP");
                string cep = Console.ReadLine();
                System.Console.WriteLine("Qual a Cidade? ");
                string cidade = Console.ReadLine();
                System.Console.WriteLine("Qual o Estado? ");
                string estado = Console.ReadLine();
                
                dadoEndereco =  logradouro + ";" + numero + ";"  + cep + ";"  + cidade + ";"  + estado;
                return dadoEndereco;
                
            }
    }
}