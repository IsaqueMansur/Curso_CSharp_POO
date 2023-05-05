using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CadastroUsuarios
{
    internal class GraphicInterface
    {
        public enum Result_e
        {
            Success = 0,
            Exit,
            Exception
        }

        public void RenderMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public Result_e PickString(ref string myString, string message)
        {
            Result_e result;
            Console.WriteLine(message);
            string inputUser = Console.ReadLine();
            if (inputUser == "s" || inputUser == "S")
                result = Result_e.Exit;
            else
            {
                myString = inputUser;
                result = Result_e.Success;
            }
            Console.Clear();
            return result;
        }

        public Result_e pickDate(ref DateTime date, string msg)
        {
            Result_e result;

            do
            {
                try
                {
                    Console.WriteLine(msg);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        result = Result_e.Exit;
                    else
                    {
                        date = Convert.ToDateTime(temp);
                        result = Result_e.Success;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excecão: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    result = Result_e.Exception;

                }
            } while (result == Result_e.Exception);
            Console.Clear();
            return result;
        }

        public Result_e pickUint32(ref UInt32 address, string msg)
        {
            Result_e result;

            do
            {
                try
                {
                    Console.WriteLine(msg);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        result = Result_e.Exit;
                    else
                    {
                        address = Convert.ToUInt32(temp);
                        result = Result_e.Success;
                    }
                }
                catch (Exception e)
                {
                    RenderMessage("Excecão: " + e.Message);
                    result = Result_e.Exception;

                }
            } while (result == Result_e.Exception);
            Console.Clear();
            return result;
        }

        DataBase myDataBase;

        public GraphicInterface(DataBase myDataBase)
        {
            this.myDataBase = myDataBase;
        }   
        public void PrintDatasOfOneUser(People people)
        {
            Console.WriteLine("Nome: " + people.Name);
            Console.WriteLine("Documento: " + people.NumberDocument);
            Console.WriteLine("Data de nascimento: " + people.Birthday);
            Console.WriteLine("Nome da rua: " + people.NameOfWay);
            Console.WriteLine("Número da casa: " + people.NumberHouse);
        }

        public void PrintDatasOfAllUsers(List<People> listPeoples)
        {
            foreach (People people in listPeoples) 
            {
                PrintDatasOfOneUser(people);
            }
        }

        public Result_e CadasterUser()
        {
            Console.Clear();
            string Name = "";
            DateTime Birthday = new DateTime();
            string NameOfWay = "";
            string NumberDocument = "";
            UInt32 NumberHouse = 0;

            if (PickString(ref Name, "Digite o nome completo ou S para sair") != Result_e.Success)
               return Result_e.Exit;
            if (pickDate(ref Birthday, "Digite sua data de nascimento no formato 'DD/MM/YYYY' ou S para sair") != Result_e.Success)
                return Result_e.Exit;
            if (PickString(ref NameOfWay, "Digite o nome da rua ou S para sair") != Result_e.Success)
                return Result_e.Exit;
            if(PickString(ref NumberDocument, "Digite o número do documento") != Result_e.Success)
                return Result_e.Exit;
            if (pickUint32(ref NumberHouse, "Digite o número da sua casa") != Result_e.Success)
                return Result_e.Exit;

            People userCadastred = new People(Name, NumberDocument, NameOfWay, NumberHouse, Birthday);
            myDataBase.AddPeople(userCadastred);
            Console.Clear();
            Console.WriteLine("Adicionando usuário ao banco de dados");
            PrintDatasOfOneUser(userCadastred);

            return Result_e.Success;
        }

        public void FindUser()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento para buscar ou 's' para sair");
            string inputOfUser = Console.ReadLine();
            if (inputOfUser.ToLower() == "s")
                return;

            List<People> listOfPeoplesTemp = myDataBase.FindPeoplePerDocument(inputOfUser);
            Console.Clear();

            if (listOfPeoplesTemp != null)
            {
                Console.WriteLine("Usuário(s) com documento " + inputOfUser + " encontrado(s)");
                PrintDatasOfAllUsers(listOfPeoplesTemp);
            }
            else
                Console.WriteLine("Nenhum usuário encontrado");
        }

        public void RemoveUser()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento para remover um usuário ou 's' para sair");
            string inputOfUser = Console.ReadLine();
            if (inputOfUser.ToLower() == "s")
                return;

            List<People> listOfPeoplesTemp = myDataBase.RemovePeoplePerDocument(inputOfUser);
            Console.Clear();

            if (listOfPeoplesTemp != null)
            {
                Console.WriteLine("Usuário(s) com documento " + inputOfUser + " removido(s)");
                PrintDatasOfAllUsers(listOfPeoplesTemp);
            }
            else
                Console.WriteLine("Nenhum usuário encontrado");
        }

        public void UnrecognizedOption()
        {
            Console.Clear();
            RenderMessage("Opção desconhecida");
        }
        
        public void Exit()
        {
            Console.Clear();
            RenderMessage("Encerrando o programa.");
        }

        public void RunInterface()
        {
            string pressionedKey;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário");
                Console.WriteLine("Digite B para buscar um usuário pelo número do documento");
                Console.WriteLine("Digite R para remover um usuário pelo número do documento");
                Console.WriteLine("Digite S para sair");
                pressionedKey = Console.ReadKey(true).KeyChar.ToString().ToLower();
                switch(pressionedKey)
                {
                    case "c":
                        CadasterUser();
                        break;

                    case "b":
                        FindUser();
                        break;

                    case "r":
                        RemoveUser();
                        break;

                    case "s":
                        Exit();
                        break;

                    default:
                        UnrecognizedOption();
                        break;
                }

            } while (pressionedKey != "s");
        }
    }
}
