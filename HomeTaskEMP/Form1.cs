using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeTaskEMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Dictionary<double, double> x)
        {
            InitializeComponent();
            foreach (KeyValuePair<double, double> kvp in x)
            {
                chart1.Series[0].Points.AddXY(Convert.ToInt32(kvp.Key), Convert.ToInt32(kvp.Value));
                dataGridView1.Rows.Add(Convert.ToInt32(kvp.Key), Convert.ToInt32(kvp.Value));
            }
        }
    }
}
