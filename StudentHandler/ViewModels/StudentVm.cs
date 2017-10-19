using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHandler.ViewModels
{
    class StudentVm
    {
        private int age;
        private string lastname;
        private string firstname;
        private bool paid;
        private string program;

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public int Age { get => age; set => age = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public bool Paid { get => paid; set => paid = value; }
    }
}
