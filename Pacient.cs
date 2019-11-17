using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_2
{
    class Pacient
    {
        public int varsta;
        public string telefon;
        public char sex;
        public string nume_pacient;
        public DateTime data_nastere;
        public static int generator = 0;
        
        
        //de adaugat medicul asociat

        public Pacient(string nume_pacient, int varsta, string telefon, char sex, DateTime data)
        {
            this.nume_pacient = nume_pacient;
            this.varsta = varsta;
            this.telefon = telefon;
            this.sex = sex;
            this.data_nastere = data;
            generator++;
            if (this.nume_pacient.Length < 2)
              throw new Exception("Invalid name!");

            if (this.varsta < 0)
                throw new Exception("Age has to be greater then 0!");

            if (this.telefon.Length != 10)
                throw new Exception("Invalid telephone number!");

           if(this.varsta != calculVarsta(this.data_nastere))
            {
                throw new Exception("Age does not match de Date of Birth!");
            }
       


        }

        private int calculVarsta(DateTime birthday)
        {
            int varsta = DateTime.Now.Year - birthday.Year;
            if ((birthday.Month > DateTime.Now.Month) || (birthday.Month == DateTime.Now.Month && birthday.Day > DateTime.Now.Day))
                varsta--;
            return varsta;
        }
        public string Nume_pacient
        {
            get
            {
                return this.nume_pacient;
            }

            set
            {
                if (value.Length < 2)
                    MessageBox.Show("Too few characters in name");
                else
                    this.nume_pacient = value;
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
        public string Telefon
        {
            get
            {
                return this.telefon;
            }

            set
            {
                if (value.Length != 10)
                    MessageBox.Show("Nr telefon invalid");
                else
                    this.telefon = value;
            }

        }
        public char Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
            }

        }
        
        public int Generator
        {
            get
            {
                return generator;
            }
            set
            {

            }
        }

        public DateTime Data
        {
            get
            {
                return this.data_nastere;
            }
            set
            {

            }
        }

        
    }
}
