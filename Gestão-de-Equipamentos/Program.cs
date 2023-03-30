using System.Collections;
using System.Globalization;

namespace Gestão_de_Equipamentos
{
    internal class Program
    {
        private static void VisualizarEquipamentos(ArrayList idEquipamento, ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Lista de equipamentos:");

            for (int i = 0; i < idEquipamento.Count; i++)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Equipamento " + (i + 1));
                Console.WriteLine("ID: " + idEquipamento[i]);
                Console.WriteLine("NOME: " + nomeEquipamento[i]);
                Console.WriteLine("PREÇO: " + "R$" + precoEquipamento[i]);
                Console.WriteLine("NÚMERO DE SÉRIE:" + numerodeserie[i]);

                string dateString = fabricacaoEquipamento[i].ToString();
                DateTime date = DateTime.ParseExact(dateString, "ddMMyyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("DATA DE FABRICAÇÃO:" + date.ToString("dd/MM/yyyy"));

                Console.WriteLine("FABRICANTE: " + fabricanteEquipamento[i]);
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();
            }
        }
        private static void RegistroEquipamentos(ArrayList idEquipamento, ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.WriteLine("Insira o ID do equipamento:");
            idEquipamento.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Insira o nome do equipamento");
            nomeEquipamento.Add(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Insira o preço do equipamento");
            precoEquipamento.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Insira o numero de série do equipamento");
            numerodeserie.Add(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Insira a data de fabricação");
            fabricacaoEquipamento.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Insira o(a) fabricante do equipamento");
            fabricanteEquipamento.Add(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            ArrayList idEquipamento = new ArrayList();
            ArrayList nomeEquipamento = new ArrayList();
            ArrayList precoEquipamento = new ArrayList();
            ArrayList numerodeserie = new ArrayList();
            ArrayList fabricacaoEquipamento = new ArrayList();
            ArrayList fabricanteEquipamento = new ArrayList();
            bool continuar = true;



            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Insira a opção");
                Console.WriteLine("1-Registrar Equipamento");
                Console.WriteLine("2-Ver Equipamentos");

                int escolhaEquipamentos = int.Parse(Console.ReadLine());

                switch (escolhaEquipamentos)
                {
                    case 1:
                        RegistroEquipamentos(idEquipamento, nomeEquipamento, precoEquipamento, numerodeserie, fabricacaoEquipamento, fabricanteEquipamento);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;
                    case 2:
                        VisualizarEquipamentos(idEquipamento, nomeEquipamento, precoEquipamento, numerodeserie, fabricacaoEquipamento, fabricanteEquipamento);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

    }

}
