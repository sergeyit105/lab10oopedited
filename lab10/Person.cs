using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Person 
    {
        public string Name { get; set; }
        public string Sename { get; set; }
        public string Father { get; set; }
        public string Gromad { get; set; }
        public string Adress { get; set; }
        public string Phone  { get; set; }
        public bool Student { get; set; }
        public bool Vik { get; set; }
        public Person()
        {}

        public Person(string name, string sename, string father, string gromad,
        string adress, string phone, bool student, bool vik)
        {
            Name = name;
            Sename = sename;
            Father = father;
            Gromad = gromad;
            Adress = adress;
            Phone = phone;
            Student = student;
            Vik = vik;
        }
    }
}
