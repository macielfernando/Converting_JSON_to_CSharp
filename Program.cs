using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace HTTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
            requisicao.Method = "GET";
            
            using (var resposta = requisicao.GetResponse()) 
            {
               var stream = resposta.GetResponseStream();
               StreamReader leitor = new StreamReader(stream);
               object dados = leitor.ReadToEnd();

               List<Tarefa> Tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());
               foreach(Tarefa tarefa in Tarefas)
                {
                    tarefa.Exibir();
                }

               stream.Close();
               resposta.Close();
            }
               Console.ReadLine();
        }

    }
}
