using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Pessoa
    {
        public string Nome;
        public int Idade; 

        public Pessoa()
        {

        }

        public string definirNome()
        {
            Console.WriteLine("Informe o nome desejado: ");
            //string Nome;
            // Nome =  Console.ReadLine();
            //return Nome;
            return Console.ReadLine(); //O que a pessoa digitar será retornado. (Mesma coisa que o comentário)
        }

        public int definirIdade()
        {
            Console.WriteLine("Informe a idade: ");
            //int Idade;
            // Idade =  int.Parse(Console.ReadLine());
            //return Idade;
            return int.Parse(Console.ReadLine());
        }

    }

