using ProgramaçãoFuncional.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoFuncional {
    internal class Program {
        static void Main(string[] args) {

            List<Product> lista = new List<Product>();

            lista.Add(new Product("Televisor", 900.00));
            lista.Add(new Product("NoteBook", 1200.00));
            lista.Add(new Product("Xbox One", 450.00));
            lista.Add(new Product("Guitarra Ibanez", 400.00));
            
            Comparison<Product> compName = (p1, p2) => p1.Name.ToLower().CompareTo(p2.Name.ToLower());

            lista.Sort(compName);

            Console.WriteLine("Lista ordenada por nome: ");
            foreach(Product produto in lista) {
                Console.WriteLine(produto.ToString());
            }

            Console.WriteLine("\nLista ordenada por preço: ");
            lista.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            foreach(Product produto in lista) {
                Console.WriteLine(produto.ToString());
            }

        }
    }
}
