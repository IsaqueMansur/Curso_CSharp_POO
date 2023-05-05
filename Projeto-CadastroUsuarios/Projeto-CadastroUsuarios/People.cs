using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CadastroUsuarios
{
    internal class People
    {
        private string name;
        private string numberDocument;
        private string nameOfWay;
        private UInt32 numberOfHouse; 
        private DateTime birthday;

        public People(string name, string numberDocument, string nameOfWay, uint numberOfHouse, DateTime birthday)
        {
            this.name = name;
            this.numberDocument = numberDocument;
            this.nameOfWay = nameOfWay;
            this.numberOfHouse = numberOfHouse;
            this.birthday = birthday;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string NumberDocument
        { 
            get { return this.numberDocument; } 
            set { this.numberDocument = value; }
        }
        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public string NameOfWay
        {
            get { return this.nameOfWay; }
            set { this.nameOfWay = value; }
        }
        public UInt32 NumberHouse
        { 
            get { return this.numberOfHouse; }
            set { this.numberOfHouse = value; }
        }
    }
}
