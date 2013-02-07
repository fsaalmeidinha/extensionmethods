using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = null;
            Console.WriteLine("Tamanho retornado de uma string nula: {0}", texto.LengthOrDefault());


            ETipoPessoa tipoPessoa = ETipoPessoa.Fisica;
            Console.WriteLine(String.Format("Id: {0}, Descrição: {1}", tipoPessoa.ObterId(), tipoPessoa.ObterDescricao()));

            tipoPessoa = ETipoPessoa.Juridica;
            Console.WriteLine(String.Format("Id: {0}, Descrição: {1}", tipoPessoa.ObterId(), tipoPessoa.ObterDescricao()));

            Console.ReadKey();
        }
    }
}
