using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTaskEMP
{
    public partial class Regression : Form
    {
        public Regression()
        {
            InitializeComponent();
        }
        List<double> x;
        List<double> y;
        double r;
        private double Sx;
        private double Sy;

        public Regression(List<double> x, List<double> y, double r, double Sx, double Sy)
        {
            InitializeComponent();
            this.x = x; this.y = y; this.r = r; this.Sx = Sx;this.Sy = Sy;
            for (int i = 0; i < x.Count; i++)
            {
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                dataGridView1.Rows.Add(x[i], y[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double b = r * (Sx / Sy);
                double k = _4lab.Average(y);
                chart1.Series.Add("Predicted X");
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < x.Count; i++)
                {
                    chart1.Series[1].Points.AddXY(x[i], (b * x[i]) + k);
                }
            }
            catch { }
        }
    }
}
