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
using System.Drawing.Printing;
using System.IO;

namespace Cabinet_Medical_2
{
    

    public partial class MedicsF : Form
    {
        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\cabmedcu user\Database1.mdb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
        OleDbDataAdapter adapter;
        public MedicsF()
        {
            InitializeComponent();
            exrtragereDate();
            KeyDown += MedicsF_KeyDown;
        }

        private void MedicsF_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.P)
            {
              
                MessageBox.Show("Printing....");
                PrintDocument document = new PrintDocument();
                document.PrintPage += (object sender2, PrintPageEventArgs xe) =>
                {
                    Font font = new Font("Arial", 12);
                    float offset = xe.MarginBounds.Top;
                    foreach (ListViewItem Item in listView1.Items)
                    {
                        offset += (font.GetHeight() + 5.0f);
                        PointF location = new System.Drawing.PointF(xe.MarginBounds.Left, offset);
                        xe.Graphics.DrawString(Item.Text, font, Brushes.Black, location);
                    }
                };


                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = document;
                dialog.ShowDialog();
            }
        }

        private void BecomeAMedicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedic adaugare = new AddMedic();
            adaugare.Show();
        }

        private void exrtragereDate()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            DataTable dt = new DataTable();
            OleDbCommand SelectValues = connection.CreateCommand();
            SelectValues.CommandType = CommandType.Text;
            SelectValues.CommandText = "SELECT * FROM medic;";
            SelectValues.ExecuteNonQuery();
            adapter = new OleDbDataAdapter(SelectValues);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                populate(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            connection.Close();
        }

        private void populate(string id, string nume, string varsta, string specializare)
        { 
            ListViewItem rand = new ListViewItem();
            rand.Text = id;
            rand.SubItems.Add(nume);
            rand.SubItems.Add(varsta);
            rand.SubItems.Add(specializare); 
            listView1.Items.Add(rand);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            exrtragereDate();
 
        }

        private void FireAMedicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem rand_selectat = listView1.SelectedItems[0];
                if (rand_selectat != null)
                {
                    connection.Open();
                    string id_selectat = rand_selectat.SubItems[0].Text;
                    OleDbCommand RemoveValues = connection.CreateCommand();
                    RemoveValues.CommandType = CommandType.Text;
                    RemoveValues.CommandText = "DELETE FROM medic WHERE id = " + id_selectat + ";";
                    RemoveValues.ExecuteNonQuery();
                    listView1.Items.Clear();
                    exrtragereDate();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please select a Medic!");
            }
           
            
        }

        private void BackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            Close();
        }


        private void PrintMedicListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "Save File";
                sfd.Filter = "Text File (.txt) | *.txt";
                string splitter = " ";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            foreach (ListViewItem item in listView1.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}", item.SubItems[0].Text,
                                    splitter, item.SubItems[1].Text, splitter, item.SubItems[2].Text, splitter, 
                                    item.SubItems[3].Text);
                            }
                        }
                    }

                }
            }
        }
    }
}
