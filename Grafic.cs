using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Cabinet_Medical_2
{


    class Grafic : Control
    {
        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\cabmedcu user\Database1.mdb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
     
        public Grafic()
        {
            
        }

            
        public int[] getValoriVarsta(int[] valori)
        {
            if (valori == null)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                DataTable dt = new DataTable();
                OleDbCommand varsteMici = connection.CreateCommand();
                varsteMici.CommandType = CommandType.Text;
                varsteMici.CommandText = "SELECT COUNT(*) FROM pacienti WHERE varsta>= 18 AND varsta <= 30;";
                int v1 = (int)varsteMici.ExecuteScalar();


                OleDbCommand varsteMedii = connection.CreateCommand();
                varsteMedii.CommandType = CommandType.Text;
                varsteMedii.CommandText = "SELECT COUNT(*) FROM pacienti WHERE varsta>= 31 AND varsta <= 50;";
                int v2 = (int)varsteMedii.ExecuteScalar();


                OleDbCommand varsteMari = connection.CreateCommand();
                varsteMari.CommandType = CommandType.Text;
                varsteMari.CommandText = "SELECT COUNT(*) FROM pacienti WHERE varsta>= 51 AND varsta <= 99;";
                int v3 = (int)varsteMari.ExecuteScalar();

                valori = new int[3] { v1, v2, v3 };
                return valori;
            }
            else
            {
                valori = null;
                getValoriVarsta(valori);
            }
            return null;

        }

        public int[] getValoriSexe(int[] valori)
        {
            if (valori == null)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                DataTable dt = new DataTable();
                OleDbCommand sexM = connection.CreateCommand();
                sexM.CommandType = CommandType.Text;
                sexM.CommandText = "SELECT COUNT(*) FROM pacienti WHERE sex = 'M';";
                int v1 = (int)sexM.ExecuteScalar();


                OleDbCommand sexF = connection.CreateCommand();
                sexF.CommandType = CommandType.Text;
                sexF.CommandText = "SELECT COUNT(*) FROM pacienti WHERE sex = 'F';";
                int v2 = (int)sexF.ExecuteScalar();

                valori = new int[2] { v1, v2 };
                return valori;
            }
            else
            {
                valori = null;
                getValoriSexe(valori);
            }
            return null;
        }

    }
}
