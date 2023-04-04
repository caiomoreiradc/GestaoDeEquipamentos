using System.Collections;
using System.Globalization;

namespace Gestão_de_Equipamentos
{
    internal class Program
    {
        private static int Menu()
        {
            Console.Clear();
            Console.WriteLine("----------MENU EMPRESA----------");
            Console.WriteLine("        Insira uma opção");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------EQUIPAMENTOS----------");
            Console.WriteLine("1-Registrar Equipamento");
            Console.WriteLine("2-Ver Equipamentos");
            Console.WriteLine("3-Editar Equipamentos");
            Console.WriteLine("4-Excluir Equipamentos");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------CHAMADOS------------");
            Console.WriteLine("5-Registrar Chamado");
            Console.WriteLine("6-Ver Chamados");
            Console.WriteLine("7-Editar Chamados");
            Console.WriteLine("8-Excluir Chamados");
            Console.WriteLine("9-Sair");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            int escolhaEquipamentos = int.Parse(Console.ReadLine());
            return escolhaEquipamentos;
        }
        private static void RegistroEquipamentos(ArrayList idEquipamento, ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.Write("Insira o ID do equipamento: ");
            idEquipamento.Add(int.Parse(Console.ReadLine()));

            Console.Write("Insira o nome do equipamento: ");
            nomeEquipamento.Add(Console.ReadLine());

            Console.Write("Insira o preço do equipamento: ");
            precoEquipamento.Add(int.Parse(Console.ReadLine()));

            Console.Write("Insira o numero de série do equipamento: ");
            numerodeserie.Add(Console.ReadLine());

            Console.Write("Insira a data de fabricação: ");
            fabricacaoEquipamento.Add(int.Parse(Console.ReadLine()));

        
            Console.Write("Insira o(a) fabricante do equipamento: ");
            fabricanteEquipamento.Add(Console.ReadLine());
        }
        private static void VisualizarEquipamentos(ArrayList idEquipamento, ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("            Lista de equipamentos:");

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
     private static void EditarEquipamentos(ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.WriteLine("Insira o ID que deseja editar: ");
            int idEdit = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do equipamento: ");
            nomeEquipamento[idEdit - 1] = Console.ReadLine();

            Console.WriteLine("Insira o preço do equipamento: ");
            precoEquipamento[idEdit - 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de série do equipamento: ");
            numerodeserie[idEdit - 1] = Console.ReadLine();

            Console.Write("Insira a data de fabricação: ");
            fabricacaoEquipamento[idEdit - 1] = int.Parse(Console.ReadLine());

            Console.Write("Insira o(a) fabricante do equipamento: ");
            fabricanteEquipamento[idEdit - 1] = Console.ReadLine();
        }
        private static void ExcluirEquipamento(ArrayList idEquipamento, ArrayList nomeEquipamento, ArrayList precoEquipamento, ArrayList numerodeserie, ArrayList fabricacaoEquipamento, ArrayList fabricanteEquipamento)
        {
            Console.Clear();
            Console.Write("Insira o id do equipamento que deseja excluir: ");
            int idExcluir = int.Parse(Console.ReadLine());
            idEquipamento.RemoveAt(idExcluir - 1);
            nomeEquipamento.RemoveAt(idExcluir - 1);
            precoEquipamento.RemoveAt(idExcluir - 1);
            numerodeserie.RemoveAt(idExcluir - 1);
            fabricacaoEquipamento.RemoveAt(idExcluir - 1);
            fabricanteEquipamento.RemoveAt(idExcluir - 1);
        }
        private static void RegistrarChamado(ArrayList idChamado, ArrayList nomeChamado, ArrayList equipamentoChamado, ArrayList dataChamado)
        {
            Console.Clear();
            Console.Write("Insira o ID do chamado: ");
            idChamado.Add(int.Parse(Console.ReadLine()));

            Console.Write("Insira o nome do chamado: ");
            nomeChamado.Add(Console.ReadLine());

            Console.Write("Insira o nome do equipamento: ");
            equipamentoChamado.Add(Console.ReadLine());

            Console.Write("Insira a data do chamado: ");
            dataChamado.Add(int.Parse(Console.ReadLine()));
        }
        private static void VisualizarChamado(ArrayList idChamado, ArrayList nomeChamado, ArrayList equipamentoChamado, ArrayList dataChamado)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("               Lista de chamados");

            for (int i = 0; i < idChamado.Count; i++)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("ID: " + idChamado[i]);
                Console.WriteLine("NOME: " + nomeChamado[i]);
                Console.WriteLine("EQUIPAMENTO: " + equipamentoChamado[i]);

                string dataString = dataChamado[i].ToString();
                DateTime date2 = DateTime.ParseExact(dataString, "ddMMyyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("DATA DE FABRICAÇÃO:" + date2.ToString("dd/MM/yyyy"));

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();
            }
        }
        private static void EditarChamado(ArrayList nomeChamado, ArrayList equipamentoChamado, ArrayList dataChamado)
        {
            Console.Clear();
            Console.Write("Insira o ID que deseja editar: ");
            int idEdit = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome do equipamento: ");
            nomeChamado[idEdit - 1] = Console.ReadLine();

            Console.Write("Insira o equipamento do chamado: ");
            equipamentoChamado[idEdit - 1] = int.Parse(Console.ReadLine());

            Console.Write("Insira a data do chamado: ");
            dataChamado[idEdit - 1] = int.Parse(Console.ReadLine());
        }
        private static void ExcluirChamado(ArrayList idChamado, ArrayList nomeChamado, ArrayList equipamentoChamado, ArrayList dataChamado)
        {
            Console.Clear();
            Console.WriteLine("Insira o id do equipamento que deseja excluir");
            int idExcluir = int.Parse(Console.ReadLine());
            idChamado.RemoveAt(idExcluir - 1);
            nomeChamado.RemoveAt(idExcluir - 1);
            equipamentoChamado.RemoveAt(idExcluir - 1);
            dataChamado.RemoveAt(idExcluir - 1);
        }
        static void Main(string[] args)
        {
            //EQUIPAMENTOS
            ArrayList idEquipamento = new ArrayList();
            ArrayList nomeEquipamento = new ArrayList();
            ArrayList precoEquipamento = new ArrayList();
            ArrayList numerodeserie = new ArrayList();
            ArrayList fabricacaoEquipamento = new ArrayList();
            ArrayList fabricanteEquipamento = new ArrayList();

            //CHAMADOS
            ArrayList idChamado = new ArrayList();
            ArrayList nomeChamado = new ArrayList();
            ArrayList equipamentoChamado = new ArrayList();
            ArrayList dataChamado = new ArrayList();

            bool continuar = true;

            while (continuar)
            {
                int escolhaEquipamentos = Menu();

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
                    case 3:
                        EditarEquipamentos(nomeEquipamento, precoEquipamento, numerodeserie, fabricacaoEquipamento, fabricanteEquipamento);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;
                    case 4:
                        ExcluirEquipamento(idEquipamento, nomeEquipamento, numerodeserie, fabricacaoEquipamento, fabricanteEquipamento);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;
                    case 5:
                        RegistrarChamado(idChamado, nomeChamado, equipamentoChamado, dataChamado);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;

                    case 6:
                        VisualizarChamado(idChamado, nomeChamado, equipamentoChamado, dataChamado);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;

                    case 7:
                        EditarChamado(nomeChamado, equipamentoChamado, dataChamado);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;

                    case 8:
                        ExcluirChamado(idChamado, nomeChamado, equipamentoChamado, dataChamado);
                        Console.WriteLine("Deseja continuar? (s/n)");
                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continuar = false;
                        }
                        break;

                    case 9:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SAINDO...");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                        return;
                }
            }

        }

    }

}
