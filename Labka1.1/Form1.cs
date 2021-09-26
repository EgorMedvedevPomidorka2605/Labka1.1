using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using System.Windows.Forms;
using ZedGraph;



namespace Labka1._1
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "График";

        }
        private void DrawGraph()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string a = textBox1.Text;
            string b = textBox2.Text;
            string e1 = textBox3.Text;
            string f = textBox5.Text;

            double a_1 = 1;
            double b_1 = 1;
            double e1_1 = 1;
            double f_1 = 1;
            
            try
            {
                a_1 = Convert.ToDouble(a);
                b_1 = Convert.ToDouble(b);
                e1_1 = Convert.ToDouble(e);
                f_1 = Convert.ToDouble(f);


            }
            catch (Exception )
            {

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Введены неверные параметры(ничего, текст или точка)");
            }
            PointPairList list = new PointPairList();
            double xmin = -50;
            double xmax = 50;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                int i = 1;
                list.Add(x,++i);
            }
            GraphPane pane = zedGraphControl1.GraphPane;
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
