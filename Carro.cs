using System;
using System.IO;

namespace sistema_concessionaria
{

    public class Carro
    {

        private string marca { get; set; }
        private string modelo { get; set; }
        private string ano { get; set; }
        private string cor { get; set; }

        public string vendido { get; set; }

        public double preco { get; set; }
     
        int codigo = 0;
        

        
        public void CadastrarCarro()
        {

            string opcao = "1";
            do
            {
                System.Console.WriteLine("Vamos Cadastrar um novo Carro... \n ");

                System.Console.WriteLine("Qual a marca? ");
                marca = Console.ReadLine();

                System.Console.WriteLine("Qual o modelo ");
                modelo = Console.ReadLine();

                System.Console.WriteLine("Qual o ano? ");
                ano = Console.ReadLine();

                System.Console.WriteLine("Qual a cor? ");
                cor = Console.ReadLine();

                System.Console.WriteLine("Qual o preço ? ");
                preco = Convert.ToDouble(Console.ReadLine());

                vendido = "Disponível";

                codigo ++;



                string opcionais = Opcionais();

                StreamWriter cw = new StreamWriter("Cadastro de Carros.csv", true);
                cw.WriteLine(marca + ";" + modelo + ";" + ano + ";" + opcionais + ";" + preco + ";" + vendido + ";" + codigo);
                cw.Close();

                System.Console.WriteLine("Deseja Cadastrar mais Carros?");
                System.Console.WriteLine("1 - Sim \n 2 - Não");

                opcao = Console.ReadLine();



            } while (opcao == "1");



        }

        public string Opcionais()
        {
            string opcionais;

            System.Console.WriteLine("Possui Ar condicionado? ");
            System.Console.WriteLine("1 - Sim \n 2 - Não");
            string respostaA = Console.ReadLine();
            string ar;

            if (respostaA == "1")
            {
                ar = "Com Ar Condicionado";
            }
            else
            {
                ar = "Sem Ar";
            }



            System.Console.WriteLine("Possui direcao Hidráulica? ");
            System.Console.WriteLine("1 - Sim \n 2 - Não");
            string respostaB = Console.ReadLine();
            string direcao;

            if (respostaB == "1")
            {
                direcao = "Com Direção Hidráulica ";
            }
            else
            {
                direcao = "Sem Direção ";
            }

            System.Console.WriteLine("Possui Vidro elétrico? ");
            System.Console.WriteLine("1 - Sim \n 2 - Não");
            string respostaC = Console.ReadLine();
            string vidro;

            if (respostaC == "1")
            {
                vidro = "Com Vidro elétrico ";
            }
            else
            {
                vidro = "Sem Vidro elétrico";
            }

            opcionais = ar + ";" + direcao + ";" + vidro;
            return opcionais;



        }



    }








}