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
    public partial class Statistics : Form
    {
        Grafic g = new Grafic();
        public Statistics()
        {
            InitializeComponent();
  
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            if(!panel2.Controls.Contains(ucAgeStat.Instance))
            {
                ucAgeStat stat = new ucAgeStat();
                panel2.Controls.Add(stat);
                stat.BringToFront();

            }
            else
            {
                
                ucAgeStat.Instance.BringToFront();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucSexesStat.Instance))
            {
                ucSexesStat sexStat = new ucSexesStat();
                panel2.Controls.Add(sexStat);
                sexStat.BringToFront();

            }
            else
            {
                ucSexesStat.Instance.BringToFront();
            }
        }
    }
}
