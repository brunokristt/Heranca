using System;
using System.Collections.Generic;
using ExHerancaPolimorfismo.Entidades;
using System.Globalization;

namespace ExHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.WriteLine("Valor dos produtos");
            Console.Write("Quantos produtos deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados do " + i + "º produto");
                Console.Write("Comum / Usado / Importado: C / U / I ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'c' || resposta == 'C')
                {

                    lista.Add(new Produto(nome, preco));
                }
                else if (resposta == 'U' || resposta == 'u')
                {


                    Console.Write("Data de fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new Usado(data, nome, preco));
                }
                else
                {
                    Console.WriteLine("Valor da taxa de importação: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Importado(taxa, nome, preco));
                }

            }

                Console.WriteLine();
                Console.WriteLine("Etiqueta de preços");

                foreach(Produto produto in lista)
                {
                    Console.WriteLine(produto.Etiqueta());
                }
            


            
        }
    }
}
