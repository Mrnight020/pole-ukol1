using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_ze_skolniho_materialu_5_a_7
{
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int cislob = Convert.ToInt32(numericUpDown2.Value);
            int pocetcisel = Convert.ToInt32(numericUpDown1.Value);
            int[] pole1 = new int[pocetcisel];
            label4.Text = "Menší jak" + cislob;
            label3.Text = "Větší jak" + cislob;

            int pocetmensi = 0;
            int pocetvetsi = 0;
            int duplicity = 0;

            Random rng = new Random();

            for (int i = 0; i < pocetcisel; i++)
            {
                pole1[i] = rng.Next(0, 101);
                if (cislob > pole1[i]) pocetmensi++;
                if (cislob < pole1[i]) pocetvetsi++;
                if (cislob == pole1[i]) duplicity++;
            }

            foreach (int c in pole1)
            {
                listBox1.Items.Add(c);
            }
            Array.Sort(pole1);

            int [] pole2 = pole1.Take(pocetmensi).ToArray();

            if (pocetmensi > 0)
            {
                foreach (int c in pole2)
                {
                    listBox2.Items.Add(c);
                }
            }

            pole2 = pole1.Skip(pocetmensi + duplicity).ToArray();

            if (pocetvetsi > 0)
            {
                foreach (int c in pole2)
                {
                    listBox3.Items.Add(c);
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
