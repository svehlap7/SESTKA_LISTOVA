using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Soucet(List<double> list, int poc, out double souc)
        {
            souc = 0;
            if (list.Count() < poc)
            {
                return false;
            }

            for (int x = 0; x < poc; x++)
            {
                souc += list[x];
            }
            return true;
        }

        public void Vypis(List<double> list, ListBox l)
        {
            l.Items.Clear();

            foreach (double x in list)
            {
                l.Items.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> list = new List<double>();
            int n = Convert.ToInt32(textBox1.Text);
            double a1 = Convert.ToDouble(textBox2.Text);
            double a2 = Convert.ToDouble(textBox3.Text);
            int poc = Convert.ToInt32(textBox4.Text);

            double souc;
            double pocitani = a2 / a1;
            list.Add(a1);

            for (int i = 1; i < n; i++)
            {
                list.Add(a2);
                a2 *= pocitani;
            }

            Vypis(list, listBox1);
            bool pop = Soucet(list, poc, out souc);
            if (pop)
            {
                MessageBox.Show("Soucet je:" + souc);
            }
            else
            {
                MessageBox.Show("NELZE");
            }
        }
    }
}
