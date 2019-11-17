using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_2
{
    public partial class ucSexesStat : UserControl
    {
        Grafic g = new Grafic();

        private static ucSexesStat _instance;
        public static ucSexesStat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSexesStat();
                return _instance;
            }
        }
        public ucSexesStat()
        {
            InitializeComponent();
            DesenareSexe();
        }


        private void DesenareSexe()
        {
            int[] valoriSexe = null;
            valoriSexe = g.getValoriSexe(valoriSexe);

            chartSexes.Series["Sex"].Points.Add(valoriSexe[0]);
            chartSexes.Series["Sex"].Points[0].AxisLabel = valoriSexe[0].ToString();
            chartSexes.Series["Sex"].Points[0].LegendText = "Masculine";

            chartSexes.Series["Sex"].Points.Add(valoriSexe[1]);
            chartSexes.Series["Sex"].Points[1].AxisLabel = valoriSexe[1].ToString();
            chartSexes.Series["Sex"].Points[1].LegendText = "Feminine";


        }

        private void doc_chartSexes(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(chartSexes.Width, chartSexes.Height, chartSexes.CreateGraphics());
            chartSexes.DrawToBitmap(bmp, new Rectangle(0, 0, chartSexes.Width, chartSexes.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }


    

        private void Button2_Click_1(object sender, EventArgs e)
        {
           
           System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
           doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_chartSexes);
           PrintPreviewDialog ppd = new PrintPreviewDialog();
           ppd.Document = doc;
           ppd.ShowDialog();
            
        }
    }
}
