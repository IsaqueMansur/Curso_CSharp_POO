using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CadastroUsuarios
{
    internal class DataBase
    {
        private List<People> peopleList;

        public DataBase()
        {
            peopleList = new List<People>();
        }

        public void AddPeople(People people)
        {
            peopleList.Add(people);
        }
        public List<People> FindPeoplePerDocument(string numberOfDocument)
        {
            List<People> tempPeopleList = peopleList.Where(people => people.NumberDocument == numberOfDocument).ToList();
            if (tempPeopleList.Count > 0)
            {
                return tempPeopleList;
            }
            return null;
        }
        public List<People> RemovePeoplePerDocument(string numberOfDocument)
        {
            List<People> tempPeopleList = peopleList.Where(people => people.NumberDocument == numberOfDocument).ToList();
            if (tempPeopleList.Count > 0)
            {
                foreach(People people in tempPeopleList)
                {
                    peopleList.Remove(people);
                }
                return tempPeopleList;
            }
            return null;
        }
    }
}
