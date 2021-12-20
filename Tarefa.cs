using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    internal class Tarefa
    {
        public int UserId;
        public int id;
        public string title;
        public bool completed;


        public void Exibir()
        {
            Console.WriteLine("Objeto Tarefa");
            Console.WriteLine($"User Id:{UserId}");
            Console.WriteLine($"id:{id}");
            Console.WriteLine($"title:{title}");
            Console.WriteLine($"Finalizou?:{completed}");
            Console.WriteLine("");
            Console.WriteLine("====================================");
        }
    }



}
