using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Patients_Click(object sender, EventArgs e)
        {
            Patients pacienti = new Patients();
            this.Hide(); 
            pacienti.Show();
           
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics();

            stat.Show();
        }

        private void Medics_Click(object sender, EventArgs e)
        {
            MedicsF medici = new MedicsF();
            this.Hide();
            medici.Show();


        }
    }
}
