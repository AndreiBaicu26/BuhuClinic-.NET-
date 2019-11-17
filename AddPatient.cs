using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;

namespace Cabinet_Medical_2
{
    public partial class AddPatient : Form
    {
        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\cabmedcu user\Database1.mdb";
        const string providerName = @"System.Data.OleDb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
     
        

        public AddPatient()
        {
            InitializeComponent();
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand insertValues = connection.CreateCommand();
            insertValues.CommandType = CommandType.Text;

            
            
            try
            {
                Pacient pacNou = new Pacient(TextBoxName.Text, int.Parse(TextBoxAge.Text), TextBoxPhone.Text, char.Parse(TextBoxSex.Text), DateTime.Parse(Data_nastere.Value.ToShortDateString()));

                insertValues.CommandText = "INSERT INTO Pacienti( Nume, Varsta, Telefon, Sex, Data_nastere) VALUES ('" + pacNou.Nume_pacient + "','" + pacNou.Varsta + "','" + pacNou.Telefon + "','" + pacNou.Sex + "','"+ pacNou.data_nastere+ "');";
                insertValues.ExecuteNonQuery();
                MessageBox.Show("Patient added sucsesfully");
                TextBoxName.Text = "";
                TextBoxAge.Text = "";
                TextBoxSex.Text = "";
                TextBoxPhone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        
       
    }
}
