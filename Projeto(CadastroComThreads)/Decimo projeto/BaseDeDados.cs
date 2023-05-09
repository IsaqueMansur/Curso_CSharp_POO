using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Threading;

namespace Decimo_projeto
{
    [DataContract]
    internal class BaseDeDados
    {
        //Atributo
        [DataMember]
        private List<CadastroPessoa> listaDePessoas;
        private string caminhoBaseDeDados;

        private Mutex mutexArquivo;
        private Mutex mutexLista;
        private bool baseDisponivel;

        //Métodos
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            mutexLista.WaitOne();
            listaDePessoas.Add(pPessoa);
            mutexLista.ReleaseMutex();
            new Thread(() =>
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                Serializador.Serializa(caminhoBaseDeDados, this);
                mutexArquivo.ReleaseMutex();
                baseDisponivel = true;
            }).Start();
        }
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x=>x.NumeroDoDocumento == pNumeroDeDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (listaDePessoasTemp.Count > 0)
                return listaDePessoasTemp;
            else
                return null;
        }
        public List<CadastroPessoa> RemoverPessoaPorDoc(string pNumeroDoDocumento)
        {
            mutexLista.WaitOne();
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.Where(x => x.NumeroDoDocumento == pNumeroDoDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (listaDePessoasTemp.Count > 0)
            {
                foreach(CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    mutexLista.WaitOne();
                    listaDePessoas.Remove(pessoa);
                    mutexLista.ReleaseMutex();
                }
                new Thread(() =>
                {
                    baseDisponivel = false;
                    mutexArquivo.WaitOne();
                    Serializador.Serializa(caminhoBaseDeDados, this);
                    mutexArquivo.ReleaseMutex();
                    baseDisponivel = true;
                }).Start();
                return listaDePessoasTemp;
            }  
            else
                return null;
        }

        public bool BaseDisponivel()
        {
            return baseDisponivel;
        }


        //Construtor
        public BaseDeDados (string pCaminhoBaseDeDados)
        {
            caminhoBaseDeDados = pCaminhoBaseDeDados;
            mutexLista = new Mutex();
            mutexArquivo = new Mutex();
            baseDisponivel = true;

            new Thread(() =>
            {
                baseDisponivel = false;
                mutexArquivo.WaitOne();
                BaseDeDados baseDeDadosTemp = Serializador.Desserializa(caminhoBaseDeDados);
                mutexArquivo.ReleaseMutex();

                mutexLista.WaitOne();
                if (baseDeDadosTemp != null)
                    listaDePessoas = baseDeDadosTemp.listaDePessoas;
                else
                    listaDePessoas = new List<CadastroPessoa>();
                mutexLista.ReleaseMutex();
                baseDisponivel = true;
            }).Start();
        }
    }
}
