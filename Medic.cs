using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_2
{
    class Medic
    {
        public string nume;
        public int varsta;
        public string specializare;
       

        public Medic(string nume, int varsta, string specializare)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.specializare = specializare;

            if (this.nume.Length < 2)
                throw new Exception("Invalid name!");

            if (this.varsta < 0)
                throw new Exception("Age has to be greater then 0!");

            

        }

        public string Nume
        {
            get {
                return this.nume;
            }
            set {
                if (value.Length < 2)
                    MessageBox.Show("Too few characters in name");
                else
                    this.nume = value;
            }
        }
        public int Varsta
        {
            get => this.varsta;

            set
            {
                if (value < 0)
                    MessageBox.Show("invalid age");
                else
                    this.varsta = value;
            }

        }
        public string Specializare
        {
            get
            {
                return this.specializare;
            }
        }

        



    }
}
