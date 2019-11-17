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
    public partial class ucAgeStat : UserControl
    {
        Grafic g = new Grafic();

        private static ucAgeStat _instance;
        public static ucAgeStat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAgeStat();
                return _instance;
            }
        }

        
        public ucAgeStat()
        {
            InitializeComponent();
            DesenareVarsta();
        }

        private void DesenareVarsta()
        {
            int[] valori = null;
            valori = g.getValoriVarsta(valori);

            ChartAge.Series["Age"].Points.Add(valori[0]);
            ChartAge.Series["Age"].Points[0].Color = Color.DarkSlateBlue;
            ChartAge.Series["Age"].Points[0].AxisLabel = valori[0].ToString();
            ChartAge.Series["Age"].Points[0].LegendText = "Young patients";

            ChartAge.Series["Age"].Points.Add(valori[1]);
            ChartAge.Series["Age"].Points[1].Color = Color.Wheat;
            ChartAge.Series["Age"].Points[1].AxisLabel = valori[1].ToString();
            ChartAge.Series["Age"].Points[1].LegendText = "Adult patients";

            ChartAge.Series["Age"].Points.Add(valori[2]);
            ChartAge.Series["Age"].Points[2].Color = Color.SpringGreen;
            ChartAge.Series["Age"].Points[2].AxisLabel = valori[2].ToString();
            ChartAge.Series["Age"].Points[2].LegendText = "Old patients";

        }
        private void doc_chartAge(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(ChartAge.Width, ChartAge.Height, ChartAge.CreateGraphics());
            ChartAge.DrawToBitmap(bmp, new Rectangle(0, 0, ChartAge.Width, ChartAge.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

     
        private void Button1_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_chartAge);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            ppd.ShowDialog();
        }
    }
}
