using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Cabinet_Medical_2
{
    public partial class AddMedic : Form
    {
        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\cabmedcu user\Database1.mdb";
        const string providerName = @"System.Data.OleDb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
        public AddMedic()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            panel1.DragEnter += dragEnter;
            panel1.DragDrop += dragDrop;
          
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        
        private void dragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(data!= null)
            {
                foreach (string name in data)
                {
                    string valori = File.ReadAllText(name);
                    string[] data2 = valori.Split(',');
                    if (data2.Length == 3)
                    {
                        TextBoxName.Text = data2[0];
                        TextBoxAge.Text = data2[1];
                        textBoxSpec.Text = data2[2];
                    }
                    else
                    {
                        MessageBox.Show("Insert more data into txt file!");
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand insertValues = connection.CreateCommand();
            insertValues.CommandType = CommandType.Text;

            try
            {
                Medic MedicNou = new Medic(TextBoxName.Text, int.Parse(TextBoxAge.Text), textBoxSpec.Text);

                insertValues.CommandText = "INSERT INTO Medic( Nume, Varsta, Specializare) VALUES ('" + MedicNou.nume + "','" + MedicNou.varsta + "','" + MedicNou.specializare + "');";
                insertValues.ExecuteNonQuery();
                MessageBox.Show("You became a medic!");
                TextBoxName.Text = "";
                TextBoxAge.Text = "";
                textBoxSpec.Text = "";
               
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
